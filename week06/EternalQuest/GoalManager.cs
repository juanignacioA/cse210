using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nScore: {_score} | Level: {GetPlayerLevel()}");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (type == "1") _goals.Add(new SimpleGoal(name, description, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals available. Please create or load goals first.");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string name = _goals[i].GetStringRepresentation().Split(':')[1].Split(',')[0];
            Console.WriteLine($"{i + 1}. {name}");
        }

        Console.Write("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int index))
        {
            index -= 1; 
            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                
                if (goal.IsComplete() && goal is SimpleGoal)
                {
                    Console.WriteLine("This goal is already completed.");
                    return;
                }

                goal.RecordEvent();
                int pointsEarned = int.Parse(goal.GetStringRepresentation().Split(':')[1].Split(',')[2]);
                _score += pointsEarned;

                if (goal is ChecklistGoal checklist && checklist.IsComplete())
                {
                    _score += checklist.GetBonus();
                    Console.WriteLine($"Bonus earned: {checklist.GetBonus()}!");
                }

                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            }
            else
            {
                Console.WriteLine("Invalid selection. That goal number does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals) sw.WriteLine(g.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename)) return;

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(data[0], data[1], data[2]);
                if (bool.Parse(data[3])) sg.RecordEvent();
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], data[2]));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[4]), int.Parse(data[3]));
                cg.SetAmountCompleted(int.Parse(data[5]));
                _goals.Add(cg);
            }
        }
    }

    private string GetPlayerLevel()
    {
        if (_score >= 5000) return "Grand Master";
        if (_score >= 2000) return "Expert";
        if (_score >= 1000) return "Pro";
        if (_score >= 500) return "Apprentice";
        if (_score > 0) return "Beginner";
        return "Newbie";
    }

}
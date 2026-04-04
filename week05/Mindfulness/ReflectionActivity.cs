using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?"
    };

    // EXCEEDING REQUIREMENTS: List to track unused questions
    private List<string> _unusedQuestions = new List<string>();

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.") 
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {_prompts[random.Next(_prompts.Count)]} --- ");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // EXCEEDING REQUIREMENTS: Use the non-repeating logic
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            ShowSpinner(7);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    // EXCEEDING REQUIREMENTS: Helper method to ensure no repeats
    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string selection = _unusedQuestions[index];
        
        _unusedQuestions.RemoveAt(index);
        
        return selection;
    }
}
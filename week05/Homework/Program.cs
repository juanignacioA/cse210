using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Ignacio", "Math");

        Console.WriteLine(assignment1.GetSummary());

        Assignment assignment2 = new Assignment("Ignacio Silva", "Adition");
        Console.WriteLine(assignment2.GetSummary());

        MathAssignment assignment3 = new MathAssignment("Jorge Smith", "Natural Numbers", "3", "1, 2, 3");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetHomeworkList());

        WritingAssignment assignment4 = new WritingAssignment("Nathan", "Olimpic Games", "Gold Medals");
        Console.WriteLine(assignment4.GetSummary());
        Console.WriteLine(assignment4.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your fisrt name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");

    }
}
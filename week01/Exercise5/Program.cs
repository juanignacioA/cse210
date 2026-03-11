using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcomeMessage();

        string userNameA = PromptUserName();
        int userNumberA = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumberA);

        DisplayResult(userNameA, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int sqr = number * number;
        return sqr;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
} 
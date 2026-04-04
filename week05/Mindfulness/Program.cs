using System;

// EXCEEDING REQUIREMENTS: Implemented a "no-Repeat" system to ensure all reflection questions are shown before any repeats occur.(ReflectionActivity.cs in lines 23, 49, 59)
class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        while (userInput != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (userInput == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (userInput == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
    }
}
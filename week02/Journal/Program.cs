using System;


class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        RandomPromptGenerator promptGen = new RandomPromptGenerator();
        
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");
        

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1") // Write
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._txPrompt = prompt;
                newEntry._txEntry = response;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2") // Display
            {
                theJournal.DisplayEntries();
            }
            else if (choice == "3") // Load
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFile(fileName);
            }
            else if (choice == "4") // Save
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.SaveFile(fileName);
            }
            else
            {
                if(choice != "5"){
                    Console.WriteLine("\nInvalid option. Please choose a number from 1 to 5.");
                }
                
            }
        }
    }
}
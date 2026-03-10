using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        int gradeP = int.Parse(Console.ReadLine());

            string letter = "";

            if (gradeP >= 90)
            {
                letter = "A";
            }
            else if (gradeP >= 80)
            {
                letter = "B";
            }
            else if (gradeP >= 70)
            {
                letter = "C";
            }
            else if (gradeP >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");
            
            if (gradeP >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You will need to retake the course, good luck!");
            }
    }
}
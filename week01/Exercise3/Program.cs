using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessN = -1;

        while (guessN != magicNumber)
        {
            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            guessN = int.Parse(Console.ReadLine());

            if ( guessN == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if ( guessN > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            } 
        }

    }
}
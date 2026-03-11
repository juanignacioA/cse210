using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
               numbers.Add(number); 
            }



        }while (number != 0);

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The average is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}
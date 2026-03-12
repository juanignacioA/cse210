using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Methods
        job1.Display();


        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Methods
        job2.Display();

        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._personName = "Miguel Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Methods
        myResume.Display();



    }
}
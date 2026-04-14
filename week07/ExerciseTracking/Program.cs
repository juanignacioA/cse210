using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("25 May 2025", 30, 4.8));
            activities.Add(new StationaryBicycle("25 May 2025", 30, 20.0));
            activities.Add(new Swimming("25 May 2025", 30, 20));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
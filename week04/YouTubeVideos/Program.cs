using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Introduction to Abstraction in C#", "Teacher Julio", 900);
        v1.AddComment(new Comment("CsharpLearner", "Great introduction! The car example really made it clear."));
        v1.AddComment(new Comment("Sofía-Dev", "Teacher Julio, thank you for simplifying this complex topic."));
        v1.AddComment(new Comment("JuanArballo", "I'm excited to apply this to our Week 04 project."));
        v1.AddComment(new Comment("RexburgDev", "Does abstraction also help with security?"));
        videos.Add(v1);


        Video v2 = new Video("Deep Dive into Encapsulation", "Teacher Julio", 1200);
        v2.AddComment(new Comment("CodeMasterBYU", "The distinction between public and private properties is crucial. Thanks!"));
        v2.AddComment(new Comment("Elena_Code", "Teacher Julio, can you clarify why we should avoid 'public' variables?"));
        v2.AddComment(new Comment("Pedro-Programmer", "This perfectly prepares me for next week's assignment on Encapsulation."));
        v2.AddComment(new Comment("Alice_Coder", "Love the real-world analogies, Teacher Julio!"));
        videos.Add(v2);

        Video v3 = new Video("Managing Multiple Classes and Lists", "Teacher Julio", 750);
        v3.AddComment(new Comment("BYU_Student1", "This structure with Video having a list of Comments is exactly what I needed."));
        v3.AddComment(new Comment("Maria-Learn", "The 'for each' loop demonstration for displaying comments was helpful."));
        v3.AddComment(new Comment("Ignacio", "How does this scale if we have thousands of videos, Teacher Julio?"));
        v3.AddComment(new Comment("ClassmateBYUI", "Great content as always!"));
        videos.Add(v3);

        Video v4 = new Video("Preparing Your Week 04 Foundation Screenshot", "Teacher Julio", 450);
        v4.AddComment(new Comment("SubmissionHelp", "This walkthrough saved my grade. I almost missed the count method!"));
        v4.AddComment(new Comment("TechSupportRex", "Teacher Julio, can you confirm the screenshot needs to show the count?"));
        v4.AddComment(new Comment("GradeAStudent", "Thanks for reminding us not to overcomplicate the foundation projects."));
        v4.AddComment(new Comment("BYUI_Support", "Exactly what students need to see before submitting!"));
        videos.Add(v4);

    
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("BYU-IDAHO CSE 210 VIDEO TUTORIAL TRACKER");
        Console.WriteLine("---------------------------------------------\n");

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "How to Start Playing Dungeons & Dragons",
            "Critical Dice Academy",
            1245
        );

        Video video2 = new Video(
            "C# Classes and Objects Explained",
            "CodeCraft Tutorials",
            980
        );

        Video video3 = new Video(
            "Building the Ultimate Gaming PC in 2026",
            "Tech Forge",
            1560
        );

        Video video4 = new Video(
            "Palworld Breeding Guide: Creating the Perfect Pal",
            "Pocket Gamer Lab",
            1890
        );

        video1.AddComment(new Comment(
            "DragonbornDave",
            "This finally helped me understand how to create my first character!"
        ));

        video1.AddComment(new Comment(
            "DiceGoblin",
            "The explanation of combat rules was really clear."
        ));

        video1.AddComment(new Comment(
            "WizardWannabe",
            "Can you make a video about spellcasting next?"
        ));


        video2.AddComment(new Comment(
            "BeginnerCoder",
            "I finally understand why we use classes now."
        ));

        video2.AddComment(new Comment(
            "SyntaxSam",
            "The examples made inheritance much easier."
        ));

        video2.AddComment(new Comment(
            "NullReference",
            "Great explanation of encapsulation!"
        ));


        video3.AddComment(new Comment(
            "BuildMaster",
            "That cable management was incredible."
        ));

        video3.AddComment(new Comment(
            "GPUHunter",
            "The graphics card recommendations were helpful."
        ));

        video3.AddComment(new Comment(
            "PCNoob",
            "I built my first computer because of this guide."
        ));


        video4.AddComment(new Comment(
            "PalTrainer",
            "The breeding chain explanation saved me hours."
        ));

        video4.AddComment(new Comment(
            "LegendaryHunter",
            "Finally got the passive skills I wanted!"
        ));

        video4.AddComment(new Comment(
            "BaseBuilder",
            "Would love to see a guide about base optimization."
        ));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._secLength} seconds");
            Console.WriteLine($"Comment Count: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
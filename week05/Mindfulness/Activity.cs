using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");

        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");

        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationSet = new List<string>();
        animationSet.Add("|");
        animationSet.Add("/");
        animationSet.Add("-");
        animationSet.Add("\\");

        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in animationSet)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
            
        }
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}
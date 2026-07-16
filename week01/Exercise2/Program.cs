using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        int grade = 87;
        string letterGrade = "";
        string symbolGrade = "";

        int passGrade = 70;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade % 10 >= 7 && !(letterGrade == "A" || letterGrade == "F"))
        {
            symbolGrade = "+";
        }
        else if (grade % 10 < 3 && !(letterGrade == "F"))
        {
            symbolGrade = "-";
        }

        Console.WriteLine($"{letterGrade}{symbolGrade}");

        if (grade >= passGrade)
        {
            Console.WriteLine("You have passed the course! Well done!");
        }
        else
        {
            Console.WriteLine("You have failed the course. Please retake the course.");
        }
    }
}
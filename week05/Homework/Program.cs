using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Step 3: Create the base class
        Assignment assignment1 = new Assignment();

        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        // Step 4: Create the MathAssignment Class
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        // Step 5: Create the WritingAssignment class
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "The Causes of World War II");
        assignment3.SetStudentName("Mary Waters");
        assignment3.SetTopic("European History");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();
    }
}
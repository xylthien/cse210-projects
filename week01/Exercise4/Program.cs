using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();
        bool loopVar = true;
        float total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (loopVar)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int userInputNumber = int.Parse(userInput);
            if (!(userInputNumber == 0))
                numberList.Add(userInputNumber);
            else
                loopVar = false;
        }

        foreach (int number in numberList)
        {
            total += number;
        }

        float average = total / numberList.Count;
        int maxValue = numberList.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxValue}");
    }
}
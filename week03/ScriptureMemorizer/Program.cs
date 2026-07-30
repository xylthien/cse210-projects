using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int numberWordsToHide = 3;

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct all thy paths.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter or type quit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(numberWordsToHide);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

// Enhancement: I added a functionallity to the random prompt generation so 
// that it won't pull the same prompt twince in a row, assuming that
// the user doesn't close the prgram in between entries.

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";

        List<journalEntry> journal = new List<journalEntry>();
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?"
        };

        Random random = new Random();

        while (userChoice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select from one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            Console.WriteLine();

            if (userChoice == "1")
            {
                bool repeatPrompt = true;
                int savedPrompt = 0;
                int randomPrompt = 0;

                while (repeatPrompt)
                {
                    randomPrompt = random.Next(prompts.Count);

                    if (!(randomPrompt == savedPrompt))
                    {
                        repeatPrompt = false;
                        savedPrompt = randomPrompt;
                    }
                }

                string prompt = prompts[randomPrompt];

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("MM/dd/yyyy");

                journalEntry newEntry = new journalEntry(date, prompt, response);

                journal.Add(newEntry);
            }
            else if (userChoice == "2")
            {
                if (journal.Count == 0)
                {
                    Console.WriteLine("There are no journal entries to display as of yet.");
                }
                else
                {
                    foreach (journalEntry entry in journal)
                    {
                        Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
                        Console.WriteLine(entry._response);
                        Console.WriteLine();
                    }
                }

            }
            else if (userChoice == "3")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                journal.Clear();

                using (StreamReader inputfile = new StreamReader(fileName))
                {
                    while (!inputfile.EndOfStream)
                    {
                        string date = inputfile.ReadLine();
                        string prompt = inputfile.ReadLine();
                        string response = inputfile.ReadLine();

                        journalEntry newEntry = new journalEntry(date, prompt, response);

                        journal.Add(newEntry);
                    }

                }
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (journalEntry entry in journal)
                    {
                        outputFile.WriteLine(entry._date);
                        outputFile.WriteLine(entry._prompt);
                        outputFile.WriteLine(entry._response);
                    }
                }
                Console.WriteLine("Journal has been saved successfully!");
            }
            else if (userChoice != "5")
            {
                Console.WriteLine("User has selected an option that does not exist!");
            }
        }

    }
}
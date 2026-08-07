using System;

class Program
{
    static void Main(string[] args)
    {
        // I added an if-statement to catch potential issues if the user entered something that was not an integer.
        // This issue would come up with the listing activity. You'd be listing things, lose track of time, and input a string where an integer should go!
        // NO LONGER! It's fixed :)

        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program.");
        Console.WriteLine();

        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
           
           if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("Please a number from 1-4.");
                Console.WriteLine();
                continue;
            }

            Console.WriteLine();
            switch (userChoice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
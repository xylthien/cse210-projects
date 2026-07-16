using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(0, 100);
            int userGuess = 10000;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);
                guessCount++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }
            } while (!(userGuess == magicNumber));

            Console.WriteLine($"It took you {guessCount} guesses to guess my Magic Number!");
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}
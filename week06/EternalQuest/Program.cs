class Program
{
    static void Main(string[] args)
    {
        // There were a few edge casses that needed to be handled, mostly involving Console.ReadLine() for integers.
        // I wrote GetIntergerInput() to help rule out strings or numbers outside parameters. 
        Console.Clear();
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
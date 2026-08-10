public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int menuChoice = 0;

        while (menuChoice != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            menuChoice = GetIntegerInput(1, 6);
            Console.WriteLine();

            switch (menuChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i =0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(_goals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        Console.Write("\nWhich type of goal would you like to create? ");
        int userChoice = GetIntegerInput(1, 3);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("How many points is this goal worth? ");
        int points = GetIntegerInput(1);

        Goal goal = null;

        switch (userChoice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times do you want to repeat this task? ");
                int target = GetIntegerInput(1);

                Console.Write("How many bonus points for completing the entire goal? ");
                int bonus = GetIntegerInput(1);

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals to record.");
            return;
        }
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = GetIntegerInput(1, _goals.Count);

        Goal goal = _goals[choice - 1];
        int pointsEarned = goal.GetPointsForEvent();
        goal.RecordEvent();

        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>();

        lines.Add(_score.ToString());

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }

        File.WriteAllLines(filename, lines);
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            switch (parts[0])
            {
                case "SimpleGoal":
                    {
                        SimpleGoal goal = new SimpleGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3])
                        );

                        if (bool.Parse(parts[4]))
                        {
                            goal.RecordEvent();
                        }

                        _goals.Add(goal);
                        break;
                    }
                case "EternalGoal":
                    {
                        EternalGoal goal = new EternalGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3])
                        );

                        _goals.Add(goal);
                        break;
                    }
                case "ChecklistGoal":
                    {
                        ChecklistGoal goal = new ChecklistGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            int.Parse(parts[5]),
                            int.Parse(parts[6])
                        );

                        int amountCompleted = int.Parse(parts[4]);

                        for (int j = 0; j < amountCompleted; j++)
                        {
                            goal.RecordEvent();
                        }

                        _goals.Add(goal);
                        break;
                    }
            }
        }
    }
    
    private int GetIntegerInput(int minimum, int maximum = int.MaxValue)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= minimum && number <= maximum)
                {
                    return number;
                }
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }
}
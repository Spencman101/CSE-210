class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Enter the number of times to complete the goal: ");
                int requiredTimes = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, requiredTimes, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            int pointsEarned = goals[choice].RecordEvent();
            score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {score}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
        Console.WriteLine($"Total Score: {score}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType},{goal.Name},{goal.Description},{goal.Points}");

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.GetType().Name},{checklistGoal.DisplayStatus()}");
                }
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(name, description, points));
                        break;

                    case "EternalGoal":
                        goals.Add(new EternalGoal(name, description, points));
                        break;

                    case "ChecklistGoal":
                        int timesCompleted = int.Parse(parts[4]);
                        int requiredTimes = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);

                        var checklistGoal = new ChecklistGoal(name, description, points, requiredTimes, bonusPoints);
                        for (int i = 0; i < timesCompleted; i++)
                        {
                            checklistGoal.RecordEvent();
                        }
                        goals.Add(checklistGoal);
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}

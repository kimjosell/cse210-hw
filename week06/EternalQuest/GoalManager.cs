using System.Configuration.Assemblies;

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
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You now have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Create Bad Habit");
            Console.WriteLine("  7. Quit.");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    CreateBadHabit();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }



    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalsDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateBadHabit()
    {
        Console.Write("What is the name of your bad habit? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your bad habit? ");
        string description = Console.ReadLine();
        Console.Write("How many points will you lose for this bad habit? ");
        string points = Console.ReadLine();

        BadHabits badHabits = new BadHabits(name, description, points);
        _goals.Add(badHabits);
        Console.WriteLine($"Bad Habit created successfully!");
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                Console.WriteLine($"Goal created successfully!");
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                Console.WriteLine($"Goal created successfully!");
                break;
            case "3":

                Console.Write("How many times does this goal need to be completed? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(checkListGoal);
                Console.WriteLine($"Goal created successfully!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete? Please enter the number:");

        List<Goal> incompleteGoals = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                incompleteGoals.Add(goal);
            }
        }

        for (int i = 0; i < incompleteGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {incompleteGoals[i].GetDetailsString()}");
        }
        Console.Write("Enter the number of the goal you completed: ");
        string choice = Console.ReadLine();
        int index = int.Parse(choice) - 1;
        if (index < 0 || index >= incompleteGoals.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

        Goal finalgoal = incompleteGoals[index];

        finalgoal.RecordEvent();

        if (finalgoal is BadHabits badhabits)
        {
            _score -= int.Parse(finalgoal.GetPoints());
        }
        else
        {
            _score += int.Parse(finalgoal.GetPoints());
        }
        
        if(finalgoal is CheckListGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }
        }
        

    }

    public void SaveGoals()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            outputFile.WriteLine($"{_score},");
            foreach (Goal goal in _goals)
            {
                if (goal is CheckListGoal checklistGoal)
                {
                    outputFile.WriteLine($"c,{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsComplete()},{checklistGoal.GetBonus()},{checklistGoal.GetTarget()},{checklistGoal.GetAmountCompleted()}");
                }
                if (goal is SimpleGoal simpleGoal)
                {
                    outputFile.WriteLine($"s,{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsComplete()}");
                }
                if (goal is EternalGoal eternalGoal)
                {
                    outputFile.WriteLine($"e,{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsComplete()}");
                }
                if (goal is BadHabits badHabits)
                {
                    outputFile.WriteLine($"b,{goal.GetName()},{badHabits.GetDescription()},{badHabits.GetPoints()}");
                }
            }
        }

        Console.WriteLine("Goals saved Successfully!");
    }

    public void LoadGoals()
    {
        string fileName = "myFile.txt";
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        string v = lines[0].Split(',')[0];
        _score = int.Parse(v);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts[0] == "c")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                string isComplete = parts[4];
                int bonus = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int amountCompleted = int.Parse(parts[7]);
                CheckListGoal checklistGoal = new CheckListGoal(name, description, points, target, bonus);
                if (amountCompleted > 0)
                {
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checklistGoal.RecordEvent(); // Mark as complete for each completed instance
                    }
                }
                _goals.Add(checklistGoal);
            }
            if (parts[0] == "s")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                string isComplete = parts[4];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if (isComplete == "True")
                {
                    simpleGoal.RecordEvent(); // Mark as complete
                }
                _goals.Add(simpleGoal);
            }
            if (parts[0] == "e")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                string isComplete = parts[4];
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            if (parts[0] == "b")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                BadHabits badHabits = new BadHabits(name, description, points);
                _goals.Add(badHabits);
            }

        }
        Console.WriteLine("Goals Loaded Successfully!");
    }
}
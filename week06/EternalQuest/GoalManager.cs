using System;
using System.Collections.Generic;
using System.IO;

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
            Console.WriteLine("\nWelcome to the Goal Manager!");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Score");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Delete a Goal");
            Console.WriteLine("9. Quit\n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    DisplayPlayerInfo();
                    break;
                case "6":
                    SaveGoal();
                    break;
                case "7":
                    LoadGoal();
                    break;
                case "8":
                    DeleteGoal();
                     break;

                case "9":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;

            }
        }
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("\n--------- Your Goals ---------");
    for (int i = 0; i < _goals.Count; i++)
    {
        Goal goal = _goals[i];

        Console.ForegroundColor = goal.IsComplete() ? ConsoleColor.Green : ConsoleColor.Yellow;
        Console.Write($"[{(goal.IsComplete() ? "x" : " ")}] ");
        Console.ResetColor();

        Console.WriteLine(goal.GetGoalName());
    }
    Console.WriteLine("\nPress Enter to return to menu...");
    Console.ReadLine();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\n--- Your Goals (Details) ---");
    for (int i = 0; i < _goals.Count; i++)
    {
        Goal goal = _goals[i];

        Console.ForegroundColor = goal.IsComplete() ? ConsoleColor.Green : ConsoleColor.Yellow;
        Console.Write($"[{(goal.IsComplete() ? "x" : " ")}] ");
        Console.ResetColor();

        Console.WriteLine($"{goal.GetGoalName()} - {goal.GetDetailsString()}");
    }
    Console.WriteLine("\nPress Enter to return to menu...");
    Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
       Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal selectedGoal = _goals[choice];
        selectedGoal.RecordEvent();

        
        _score += selectedGoal.GetPoints();

        
        if (selectedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete() && checklist.GetAmountCompleted() == checklist.GetAmountCompleted())
            {
                _score += checklist.GetBonus();
                Console.WriteLine($"You completed the checklist goal and earned a bonus of {checklist.GetBonus()} points!");
            }
        }

        Console.WriteLine($"Event recorded! You earned {selectedGoal.GetPoints()} points.");
    }
 

    public void SaveGoal()
    {
        Console.Write("Enter file name to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"Score|{_score}");

        }

            Console.WriteLine("Goals saved successfully.");
}

    public void LoadGoal()
    {
       Console.Write("Enter file name to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts[0] == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (isComplete)
                {
                    g.RecordEvent(); 
                }
                _goals.Add(g);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                for (int i = 0; i < int.Parse(parts[4]); i++)
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
            else if (parts[0] == "Score")
            {
                _score = int.Parse(parts[1]);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void DeleteGoal()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals to delete.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("\nSelect a goal to delete:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Goal goal = _goals[i];
        Console.ForegroundColor = goal.IsComplete() ? ConsoleColor.Green : ConsoleColor.Yellow;
        Console.Write($"[{(goal.IsComplete() ? "x" : " ")}] ");
        Console.ResetColor();
        Console.WriteLine($"{i + 1}. {goal.GetGoalName()}");
    }

    Console.Write("Enter the goal number to delete: ");
    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _goals.Count)
    {
        _goals.RemoveAt(choice - 1);
        Console.WriteLine("Goal deleted successfully!");

        SaveAfterDeletion();
    }
    else
    {
        Console.WriteLine("Invalid selection.");
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

private void SaveAfterDeletion()
{
    Console.Write("Enter file name to update (or type the original file name): ");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
        writer.WriteLine($"Score|{_score}");
    }

    Console.WriteLine("File updated successfully.");
}

    
}
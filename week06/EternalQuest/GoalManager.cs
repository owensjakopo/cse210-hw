using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(Goal goals, int score)
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager! What would you like to do today?");
        Console.WriteLine("Simple Goal");
        Console.WriteLine("Eternal Goal");
        Console.WriteLine("Checklist Goal");

        string choice = Console.ReadLine();
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDeatails()
    {
        
    }

    public void CreateGoal()
    {
        
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoal()
    {
        
    }

    public void LoadGoal()
    {
        
    }
}
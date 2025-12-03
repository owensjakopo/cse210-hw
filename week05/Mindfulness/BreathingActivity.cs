using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you slowly through breathing in and out")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        int timeLeft = GetDuration();

        while (timeLeft > 0)
        {
           Console.Write("Breath in...");
           ShowCountDown(4);
           timeLeft -= 4;

           if (timeLeft <= 0) break;

           Console.Write("Breathe out...");
           ShowCountDown(6);
           timeLeft -= 6;

           Console.WriteLine();
        }

        DisplayEndingMessage();
    }

}
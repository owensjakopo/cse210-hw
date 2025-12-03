using System;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you overcame a challenge",
        "Think of a time you helped someone in need.",
        "Think of a time when you stood up for something you believed in."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this moment meaningful to you?",
        "How did you feel during this experience?",
        "What did you learn from this situation?",
        "How can you appy what you learned in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on moments in your life by answering questions.")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        ShowSpinner(5);

        Console.WriteLine("\nNow ponder the following questions:");
        Console.WriteLine("(Press ENTER after each question.)\n");

        foreach (string question in _questions)
        {
            Console.Write(question + " ");
            Console.ReadLine();
            ShowSpinner(4);
        }

        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    private void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are some of your personal strengths?",
        "Who are people you have helped recently?",
        "What are you grateful for today?",
        "Who has made a positive impact in your life?"
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this moment meaningful to you?",
        "How did you feel during this experience?",
        "What did you learn from this situation?",
        "How can you apply what you learned in the future?"
    };


    public ListingActivity() : base("Listing Activity", "This activity helps you reflect by listing as many positive things as you can about a prompt.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        _count = GetListFromUser();

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public int GetListFromUser()
    {
        int count = 0;
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        return count;
    }
}
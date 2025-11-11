using System;
using System.Collections.Generic;
public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Describe a memorable moment from today.",
        "If there is one thing you could change about today, what would it be?",
        "If there is one would do over today, what would it be?",
        "What are you grateful for today?",
        "Did you make any new goals today? If so, what are they?",
        "Are you okay? How are you really feeling today?",
        "Describe a challenge you faced today and how you overcame it.",
        "What is something new you learned today?",
        "How did you make someone else's day better today?"
    };
    private Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetComment()
    {
        return _commentText;
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{_commentText}");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($" - by {_commenterName}");
        Console.ResetColor();
    }
}
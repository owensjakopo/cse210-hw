using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine("====================================");
        Console.WriteLine($"{_comments.Count} Comment(s)\n");

        foreach (Comment comment in _comments)
        {
            comment.Display();
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
#pragma warning disable CA1416 // Disable platform compatibility warning for Console.Beep

using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nEntry {i + 1}:");
            Console.ResetColor();
            _entries[i].Display();
        }
    }

    public void SaveToFile(string filename)
    {
        if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            filename += ".txt";
        }
        filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filename);
        string fullPath = Path.GetFullPath(filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath, append: true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
            Console.Beep(800, 300);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"File saved to: {fullPath}.");
            Console.ResetColor();
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            filename += ".txt";
        }
        filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", filename);
        string fullPath = Path.GetFullPath(filename);

        if (!File.Exists(fullPath))
        {
            Console.Beep(400, 500);
            Console.WriteLine("File does not exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(fullPath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };

                _entries.Add(entry);
            }

        }
        Console.Beep(1000, 200);
        Console.WriteLine($"Loaded from {fullPath}.");
    }
}
using System;
using System.Collections.Generic;
using System.Linq; 
public class Scripture
{
    private string _reference;
    private List<string> _words;

    private static Random _random = new Random();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = new List<string>(text.Split(' '));
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        List<int> visibleIndexes = Enumerable.Range(0, _words.Count)
                                              .Where(i => _words[i] != "____")
                                              .ToList();

        while (hiddenCount < numberToHide && visibleIndexes.Count > 0)
        {
            int randomIndex = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];
            
            _words[wordIndex] = "____";
            visibleIndexes.RemoveAt(randomIndex);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference} {string.Join(" ", _words)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word == "____");
    }
}
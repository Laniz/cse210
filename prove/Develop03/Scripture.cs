using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split().Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(RenderText());
    }

    public void HideWords()
    {
        Random random = new Random();
        var hiddenIndices = Enumerable.Range(0, _words.Count).OrderBy(x => random.Next()).Take(_words.Count / 3);
        foreach (var idx in hiddenIndices)
        {
            _words[idx].Hide();
        }
    }

    public bool AllHidden()
    {
        return _words.All(word => word.Hidden);
    }

    private string RenderText()
    {
        return string.Join(" ", _words.Select(word => word.Render()));
    }
}

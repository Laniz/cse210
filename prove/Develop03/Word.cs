using System;

public class Word
{
    private string _text;
    private bool _hidden;

    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }

    public bool Hidden
    {
        get { return _hidden; }
        private set { _hidden = value; }
    }

    public Word(string text)
    {
        _text = text;
        _hidden = false; // By default, words are not hidden
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public string Render()
    {
        return _hidden ? "_____" : _text; // Render hidden words as blanks
    }
}

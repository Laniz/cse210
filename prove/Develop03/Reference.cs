using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public string Book
    {
        get { return _book; }
        private set { _book = value; }
    }

    public int Chapter
    {
        get { return _chapter; }
        private set { _chapter = value; }
    }

    public string Verse
    {
        get { return _verse; }
        private set { _verse = value; }
    }

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}

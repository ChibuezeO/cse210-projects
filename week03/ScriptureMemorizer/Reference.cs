using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        _book = parts[0];
        string[] verseParts = parts[1].Split(':');
        _chapter = int.Parse(verseParts[0]);

        if (verseParts[1].Contains("-"))
        {
            string[] verses = verseParts[1].Split('-');
            _startVerse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
            _startVerse = int.Parse(verseParts[1]);
            _endVerse = 0;
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}

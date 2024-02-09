using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _verseRange;

    public string ReferenceString()
    {
        return $"{_book} {_chapter}:{_verse}-{_verseRange}";
    }

    // public bool ReferenceRange()
    // {

    // }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        
    }

    public Reference(string book, int chapter, int verse, string verseRange)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseRange = verseRange;
    }
}
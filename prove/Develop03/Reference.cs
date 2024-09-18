public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd; 

    public override string ToString()
    {
        if (_verse != _verseEnd)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verse;
    }

    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;  
        _verseEnd = verseEnd;
    }
}
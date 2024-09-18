public class Scripture
{
    private List<Word> _words;
    private Reference _reference; 

    public void HideWords(Random random)
    {
        int hiddenWord;
        hiddenWord = random.Next(_words.Count);

        while (_words[hiddenWord].IsHidden)
        {
            hiddenWord = random.Next(_words.Count);
        }

        _words[hiddenWord].Hide();
    }

    public bool AllHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }

    public string GetText()
    {
        return string.Join(" ", _words.Select(word => word.GetText()));
    }

    public string GetReference()
    {
        return _reference.ToString();
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    
}
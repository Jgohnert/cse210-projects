public class Word
{
    private string _text;
    private bool _hidden;

    public bool IsHidden => _hidden;

    public string GetText()
    {
        return _hidden ? new string('_', _text.Length) : _text;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
}
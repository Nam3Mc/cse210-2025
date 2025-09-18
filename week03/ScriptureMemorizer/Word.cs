public class Word
{
    string _text;
    bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string GetText()
    {
        return _text;
    }
    public bool GetStatus()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _text = new string('_', _text.Length);
        _isHidden = true;
    }
}
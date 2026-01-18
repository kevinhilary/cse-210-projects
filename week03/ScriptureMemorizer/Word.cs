class Word
{
    private string _text;   // the word text
    private bool _hidden;   // is the word hidden

    // Constructor
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    // Show word or underscores if hidden
    public string GetDisplayText()
    {
        if (_hidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    // Hide the word
    public void Hide()
    {
        _hidden = true;
    }

    // Check if hidden
    public bool IsHidden()
    {
        return _hidden;
    }
}
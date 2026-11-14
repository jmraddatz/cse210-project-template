using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText() //Display a word whether it be hidden or showing
    {
        if (_isHidden)
        {
            int count = _text.Length;
            string underscores = "";

            for (int i = 0; i < count; i++)
            {
                underscores += "_";
            }

            return underscores;

        }
        else
        {
            return _text;
        }
    }
}
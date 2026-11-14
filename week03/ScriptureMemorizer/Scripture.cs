using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] words = text.Split(" ");
        _words = new List<Word>();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> hideList = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                hideList.Add(word);
            }
        }

        Random range = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            if (hideList.Count == 0)
            {
                break;
            }

            int ranIndex = range.Next(0, hideList.Count);
            Word ranWord = hideList[ranIndex];

            ranWord.Hide();
            hideList.Remove(ranWord);
        }

    }

    public string GetDisplayText()
    {
        string scripture = _reference.GetDisplayText();
        string displayWord = "";

        foreach (Word word in _words)
        {
            displayWord += $" {word.GetDisplayText()}";

        }
        return $"{scripture} {displayWord}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
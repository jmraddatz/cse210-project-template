using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _favorite;

    public void Display()
    {
        _date = ($"{DateTime.Now.ToShortDateString()}--");

        PromptGenerator prompt = new PromptGenerator();
        _promptText = ($"{prompt.GetRandomPrompt()}--");
        Console.WriteLine(_promptText);

        Console.Write("> ");
        _entryText = Console.ReadLine();

        Console.Write("Would you like to add this to your favorites? (yes/no) ");
        _favorite = Console.ReadLine();

        if (_favorite == "yes")
        {
            using (StreamWriter favFile = new StreamWriter("Favorites.txt"))
            {
                favFile.WriteLine($"{_date}{_promptText}{_entryText}");
            }
        }

    }
}
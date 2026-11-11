using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
        }
    }
    public void LoadFromFile(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string e in entries)
        {
            string[] parts = e.Split("--");
            Entry part = new Entry();

            part._date = ($"{parts[0]}--");
            part._promptText = ($"{parts[1]}--");
            part._entryText = parts[2];

            _entries.Add(part);
        }
        Console.WriteLine($"Loaded {file}.");
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}{e._promptText}{e._entryText}");
            }
        }
        Console.WriteLine("Entry saved!");
    }
}
// I added the option for the user to add their new entry into a favorites file. The code could be developed farther, but it is a simple practice of the idea. The extra code is contained in the Entry.cs file.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");

        Journal userEntry = new Journal();
        int number;
        do
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("1. Write An Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Entry");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Display();


                userEntry.AddEntry(newEntry);
            }
            else if (number == 2)
            {
                userEntry.DisplayAll();
            }
            else if (number == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                userEntry.LoadFromFile(file);
            }
            else if (number == 4)
            {
                Console.Write("What file would you like to save to? ");
                string file = Console.ReadLine();
                userEntry.SaveToFile(file);
            }

        } while (number != 5);
    }
}
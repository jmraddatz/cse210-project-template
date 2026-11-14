// I added the recommended feature to only hide words that have not been hidden yet. I also added a feature to make the number of words hidden random each 
// time the user presses Enter.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight");
        Random ranNum = new Random();

        while (quit == false)
        {
            Console.WriteLine($"{scripture.GetDisplayText()}");

            Console.WriteLine("Press Enter to continue or type 'quit'.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                int hideNumOfWords = ranNum.Next(1, 4);
                scripture.HideRandomWords(hideNumOfWords);
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine($"{scripture.GetDisplayText()}");
                    quit = true;

                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
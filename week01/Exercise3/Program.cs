using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessCount = 0;
        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            guessCount += 1;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCount} tries.");
    }
}
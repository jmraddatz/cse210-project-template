using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string userPercent = Console.ReadLine();
        int grade = int.Parse(userPercent);

        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade >= 90)
        {
            if (grade <= 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (grade >= 80)
        {
            if (grade <= 83)
            {
                letter = "B-";
            }
            else if (grade >= 87)
            {
                letter = "B+";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (grade <= 73)
            {
                letter = "C-";
            }
            else if (grade >= 77)
            {
                letter = "C+";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            if (grade <= 63)
            {
                letter = "D-";
            }
            else if (grade >= 67)
            {
                letter = "D+";
            }
            else
            {
                letter = "D";
            }
        }

        Console.WriteLine($"You got a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass. Take what you've learned and you'll do better next time!");
        }
    }
}
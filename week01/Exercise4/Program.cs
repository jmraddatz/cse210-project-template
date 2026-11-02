using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numList.Add(number);
            }
        }

        int total = 0;
        int largest = 0;

        foreach (int numbers in numList)
        {
            total += numbers;
            if (numbers > largest)
            {
                largest = numbers;
            }
        }
        int average = total / numList.Count;
    
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}
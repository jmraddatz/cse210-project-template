using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment work = new Assignment("Josh", "Mathmatics");
        Console.WriteLine(work.GetSummary());

        MathAssignment math = new MathAssignment("7", "9-12", "Sam", "Science");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("The Causes of World War II", "Greg", "History");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", "Section 5.1", "Problems 1-10");
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "History", "The Renaissance");

        Console.WriteLine("Math Assignment Summary:");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine("Writing Assignment Summary:");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
        
    }
}
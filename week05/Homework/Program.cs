using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Owen S. Jakopo", "Algebra");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Levi T. Jakopo", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Memory Antonio Jakopo", "Teaching in the Savior's Way", "Teach Like the Savior");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}
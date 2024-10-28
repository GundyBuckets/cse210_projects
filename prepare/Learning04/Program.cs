using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing Assignment class
        /*
        Assignment newAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(newAssignment.GetSummary());
        */

        // Testing MathAssignment class
        /*
        MathAssignment newMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(newMathAssignment.GetHomeworkList());
        */

        // Testing WritingAssignment class
        WritingAssignment newWriting = new WritingAssignment("The Causes of World War II", "Mary Waters", "Earopean History");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetWritingInformation());
    }
}
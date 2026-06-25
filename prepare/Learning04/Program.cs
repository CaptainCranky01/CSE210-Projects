using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dallin Whetten", "Programming With Classes");
        MathAssignment mathAssignment = new MathAssignment("Dallin Whetten", "Algebra", "11.3", "y = x^2");
        WritingAssignment writingAssignment = new WritingAssignment("Dallin Whetten", "Writing", "Habit Experiment");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
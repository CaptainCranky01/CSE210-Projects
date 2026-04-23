using System;

class Program
{
    static void Main(string[] args)
    {
        float dw_percentage;
        char dw_letterGrade; // char cannot be null
        char? dw_plusMinus; // char? can be null
        string dw_passedMessage;
        
        dw_percentage = GetFloat("What is your grade percentage? ");

        dw_passedMessage = dw_percentage >= 70 ? "Congratulations! You passed the class!" : "You need a C- or higher to pass. Keep trying! You can do it!";
        dw_plusMinus = dw_percentage % 10 >= 7 ? '+' : (dw_percentage % 10 < 3 ? '-' : null);

        if (dw_percentage >= 90)
        {
            dw_letterGrade = 'A';
            dw_plusMinus = dw_plusMinus == '+' ? null : dw_plusMinus;
        } else if (dw_percentage >= 80)
        {
            dw_letterGrade = 'B';
        } else if (dw_percentage >= 70)
        {
            dw_letterGrade = 'C';
        } else if (dw_percentage >= 60)
        {
            dw_letterGrade = 'D';
        } else // dw_percentage < 60
        {
            dw_letterGrade = 'F';
            dw_plusMinus = null;
        }

        Console.WriteLine($"With a percentage of {dw_percentage}%, your grade is: {dw_letterGrade}{dw_plusMinus}");
        Console.WriteLine(dw_passedMessage);
    }

    static float GetFloat(string prompt)
    {
        float dw_response = 0;
        bool dw_flag = true;
        while (dw_flag)
        {
            try
            {
                Console.Write(prompt);
                dw_response = float.Parse(Console.ReadLine());
                dw_flag = false;
            } catch /*(Exception e)*/ {
//                Console.WriteLine(e);
                Console.WriteLine("Invalid input! Please type a number.");
            }
        }
        return dw_response;
    }
}
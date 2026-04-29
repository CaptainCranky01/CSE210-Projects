using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string dw_name = PromptUserName("Please enter your name: ");
        int dw_favNum = PromptUserNumber("Please enter your favorite number: ");
        int dw_year;
        PromptUserBirthYear("Please enter the year you were born: ", out dw_year);

        DisplayResult(dw_name, SquareNumber(dw_favNum), DateTime.Now.Year-dw_year);
    }

    static int SquareNumber(int input)
    {
        return input * input;
    }

    static string PromptUserName(string prompt)
    {
        string dw_return = "";
        bool dw_flag = true;
        while (dw_flag) {
            try
            {
                Console.Write(prompt);
                dw_return = Console.ReadLine();
                dw_flag = false;
            } catch
            {
                Console.WriteLine("Invalid Input! Please type your name as a string.");
            }
        }
        return dw_return;
    }

    static int PromptUserNumber(string prompt)
    {
        int dw_input = 0;
        bool dw_flag = true;
        while (dw_flag) {
            try
            {
                Console.Write(prompt);
                dw_input = int.Parse(Console.ReadLine());
                dw_flag = false;
            } catch
            {
                Console.WriteLine("Invalid Input! Please type and intiger");
            }
        }
        return dw_input;
    }
    static void PromptUserBirthYear(string prompt, out int birthYear)
    {
        int dw_input = 0;
        bool dw_flag = true;
        while (dw_flag) {
            try
            {
                Console.Write(prompt);
                dw_input = int.Parse(Console.ReadLine());
                dw_flag = false;
            } catch
            {
                Console.WriteLine("Invalid Input! Please type an intiger");
            }
        }
        birthYear = dw_input;
    }

    static void DisplayResult(string dw_name, int dw_favNum, int dw_year)
    {
        Console.WriteLine($"{dw_name}, the square of your number is: {dw_favNum}");
        Console.WriteLine($"{dw_name}, you will turn {dw_year} this year.");
    }
}
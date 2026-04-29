using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string dw_name = GetString("Please enter your name: ");
        int dw_favNum = GetInt("Please enter your favorite number: ");
        int dw_year = GetInt("Please enter the year you were born: ");

        Console.WriteLine($"{dw_name}, the square of your number is: {dw_favNum * dw_favNum}");
        Console.WriteLine($"{dw_name}, you will turn {DateTime.Now.Year-dw_year} this year.");
    }

    static int GetInt(string prompt)
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
                Console.WriteLine("Invalid Input! Please type Yes or No");
            }
        }
        return dw_input;
    }

    static string GetString(string prompt)
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
                Console.WriteLine("Invalid Input! Please type Yes or No");
            }
        }
        return dw_return;
    }
}
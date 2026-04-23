using System;

class Program
{
    static void Main(string[] args)
    {
        // I learned to declare variables first then use them later on so that it is easier to read the code
        string dw_firstName;
        string dw_lastName;

        Console.Write("What is your first name? ");
        dw_firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        dw_lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {dw_lastName}, {dw_firstName} {dw_lastName}.");
    }
}
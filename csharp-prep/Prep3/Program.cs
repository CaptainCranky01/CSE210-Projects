using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Random dw_randomGen = new Random();
            int dw_randomNum = dw_randomGen.Next(1, 100);
            int dw_guess;
            int dw_guesses = 0;
            
            Console.WriteLine("I am thinking of a random number between 1 and 100.");
            
            do
            {
                dw_guess = GetInt("Guess a whole number between 1 and 100.\n");
                dw_guesses++;
                Console.WriteLine(dw_guess > dw_randomNum ? "Lower" : (dw_guess < dw_randomNum ? "Higher" : $"You got it in {dw_guesses} guesses!"));
            } while (dw_guess != dw_randomNum);
        } while (GetYesNo("Would you like to play again? "));
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
                if (dw_input < 1 || dw_input > 100)
                {
                    throw new Exception();
                }
                dw_flag = false;
            } catch
            {
                Console.WriteLine("Invalid Input! Please type a number between 1 aand 100");
            }
        }
        return dw_input;
    }

    static bool GetYesNo(string prompt)
    {
        bool dw_return = false;
        bool dw_flag = true;
        while (dw_flag) {
            try
            {
                Console.Write(prompt);
                string dw_input = Console.ReadLine();
                if (dw_input != "Yes" && dw_input != "No")
                {
                    throw new Exception();
                }
                dw_return = dw_input == "Yes";
                dw_flag = false;
            } catch
            {
                Console.WriteLine("Invalid Input! Please type Yes or No");
            }
        }
        return dw_return;
    }
}
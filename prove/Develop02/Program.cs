using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Net;

/* Exceeding Requirements:

    I added a confirmation to saving and loading to enable the user to undo their menu choice if needed.
    I also added the option to skip prompts
    I also added a way to clear the current journal

*/

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        string[] prompts = [
            "What was the highlight of your day?: ",
            "What is one thing you would like to have done differently today?: ",
            "How many goals did you work on today?: ",
            "What was one thing you learned today?: ",
            "What did you do for fun/entertainment today?: "
        ];
        
        Journal journal = new Journal();
        int command = 0;

        Console.WriteLine("Welcome to your journal!");

        while (command != 6)
        {
            Console.WriteLine("\nList of commands:\n1: Write Entry\n2: Display\n3: Save\n4: Load\n5: Clear\n6: Exit");
            command = GetCommand("Choose 1-5: ");
            Console.WriteLine();

            if (command == 5)
            {
                if (Confirm($"Are you sure you want to clear your current journal?\ntrue/false"))
                {
                    journal._journalEntries.Clear();
                }
            } else if (command == 4)
            {
                if (Confirm($"Are you sure you want to override your current journal?\ntrue/false"))
                {
                    journal._fileName = GetString("File Name: ");
                    journal.LoadFile();
                }
            } else if (command == 3)
            {
                journal._fileName = GetString("File Name: ");

                if (Confirm($"Are you sure you want to save your current journal to {journal._fileName}?\ntrue/false"))
                {
                    journal.SaveFile();
                }
            } else if (command == 2)
            {
                journal.Display();
            } else if (command == 1)
            {
                string response;
                string prompt;

                do {
                    prompt = prompts[randomGen.Next(1, prompts.Length)];
                    response = GetString($"{prompt}\nType 'skip' to answer a different prompt\n");
                } while (response == "skip");

                journal.AddEntry(DateTime.Now, prompt, response);
            }
        }
    }

    static bool Confirm(string prompt)
    {
        bool confirm = false;
        bool flag = true;
        while (flag)
        {
            try
            {
                Console.WriteLine(prompt);
                confirm = bool.Parse(Console.ReadLine());
                flag = false;
            } catch (Exception e)
            {
                Console.WriteLine("Invalid Command! Please input 'true' or 'false'.");
            }
        }
        return confirm;
    }

    static string GetString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int GetCommand(string prompt)
    {
        int command = 0;
        bool flag = true;
        while (flag)
        {
            try
            {
                Console.Write(prompt);
                command = int.Parse(Console.ReadLine());
                if (command <= 0 || command > 5)
                {
                    throw new Exception();
                }
                flag = false;
            } catch (Exception e)
            {
                Console.WriteLine("Invalid Command! Please input an integer between 1 and 5.");
            }
        }
        return command;
    }
}
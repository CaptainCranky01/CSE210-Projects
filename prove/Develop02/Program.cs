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
        Random dw_randomGen = new Random();
        string[] dw_prompts = [
            "What was the highlight of your day?: ",
            "What is one thing you would like to have done differently today?: ",
            "How many goals did you work on today?: ",
            "What was one thing you learned today?: ",
            "What did you do for fun/entertainment today?: "
        ];
        
        Journal dw_journal = new Journal();
        int dw_command = 0;

        Console.WriteLine("Welcome to your journal!");

        while (dw_command != 6)
        {
            Console.WriteLine("\nList of commands:\n1: Write Entry\n2: Display\n3: Save\n4: Load\n5: Clear\n6: Exit");
            dw_command = GetCommand("Choose 1-5: ");
            Console.WriteLine();

            if (dw_command == 5)
            {
                if (Confirm($"Are you sure you want to clear your current journal?\ntrue/false"))
                {
                    dw_journal._DW_journalEntries.Clear();
                }
            } else if (dw_command == 4)
            {
                if (Confirm($"Are you sure you want to override your current journal?\ntrue/false"))
                {
                    dw_journal._DW_fileName = GetString("File Name: ");
                    dw_journal.LoadFile();
                }
            } else if (dw_command == 3)
            {
                dw_journal._DW_fileName = GetString("File Name: ");

                if (Confirm($"Are you sure you want to save your current journal to {dw_journal._DW_fileName}?\ntrue/false"))
                {
                    dw_journal.SaveFile();
                }
            } else if (dw_command == 2)
            {
                dw_journal.Display();
            } else if (dw_command == 1)
            {
                string dw_response;
                string dw_prompt;

                do {
                    dw_prompt = dw_prompts[dw_randomGen.Next(1, dw_prompts.Length)];
                    dw_response = GetString($"{dw_prompt}\nType 'skip' to answer a different prompt\n");
                } while (dw_response == "skip");

                dw_journal.AddEntry(DateTime.Now, dw_prompt, dw_response);
            }
        }
    }

    static bool Confirm(string prompt)
    {
        bool dw_confirm = false;
        bool dw_flag = true;
        while (dw_flag)
        {
            try
            {
                Console.WriteLine(prompt);
                dw_confirm = bool.Parse(Console.ReadLine());
                dw_flag = false;
            } catch (Exception e)
            {
                Console.WriteLine("Invalid Command! Please input 'true' or 'false'.");
            }
        }
        return dw_confirm;
    }

    static string GetString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int GetCommand(string prompt)
    {
        int dw_command = 0;
        bool dw_flag = true;
        while (dw_flag)
        {
            try
            {
                Console.Write(prompt);
                dw_command = int.Parse(Console.ReadLine());
                if (dw_command <= 0 || dw_command > 5)
                {
                    throw new Exception();
                }
                dw_flag = false;
            } catch (Exception e)
            {
                Console.WriteLine("Invalid Command! Please input an integer between 1 and 5.");
            }
        }
        return dw_command;
    }
}
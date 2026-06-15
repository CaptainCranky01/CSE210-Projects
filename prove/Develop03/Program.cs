using System;

/*

exceeding requirements:

I added a scripture archive that is loaded from a text file which allows the user to choose a scripture to memorize
I also made the hiding and displaying happen in one function and made it randomly pick a word that is still shown
I also added punctuation that will not be hidden

*/

class Program {

    static ScriptureManager DW_sm = new ScriptureManager("ScriptureArchive.txt");
    static void Main(string[] args) {
        Random DW_rg = new Random();
        string response;
        int DW_numHide;

        // Have the user choose a scripture from the archives
        Console.WriteLine("List of available scriptures:");
        Console.WriteLine(string.Join("\n", DW_sm.GetReferences()));
        string reference = PromptRef("Choose a scripture. Type out the full reference: ");
        string scripture = DW_sm.GetScripture(reference);

        // Initialize and print full scripture
        Console.WriteLine(Scripture.getInstance(reference, scripture).HideAndReturn(0));


        // Set response and test if it is "Quit" at the same time
        while ((response = PromptUser("How many words to hide? Leave blank for random up to 5. Type 'Quit' to exit program: ")) != "Quit") {
            // If they gave a valid int response then use that, otherwise pick a random one
            try {
                DW_numHide = int.Parse(response);
            } catch {
                DW_numHide = DW_rg.Next(1, 5);
            }

            // Clear and reprint with missing words
            Console.Clear();
            Console.WriteLine("\n\n" + Scripture.getInstance().HideAndReturn(DW_numHide));

            if (Scripture.getInstance().GetNumWordsLeft() <= 0) {
                return; // End program
            }
        }
    }

    static string PromptUser(string prompt) {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static string PromptRef(string prompt) {
        string DW_response = "";
        bool flag = true;
        
        Console.Write(prompt);
        while(flag) {
            try {
                DW_response = Console.ReadLine();
                if (!DW_sm.CheckReference(DW_response)) {
                    throw new Exception();
                }
                flag = false;
            } catch {
                Console.Write("Invalid Reference! Try again: ");
            }
        }
        return DW_response;
    }
}
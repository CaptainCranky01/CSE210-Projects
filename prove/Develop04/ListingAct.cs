public class ListingAct : Activity {
    private List<string> _DW_prompts;

    public ListingAct() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    ["----------", "~---------", "-~--------", "--~-------", "---~------", "----~-----", "-----~----", "------~---", "-------~--",
     "--------~-", "---------~", "----------"]) {
        _DW_prompts = new List<string>();

        _DW_prompts.Add("Who are people that you appreciate?");
        _DW_prompts.Add("What are personal strengths of yours?");
        _DW_prompts.Add("Who are people that you have helped this week?");
        _DW_prompts.Add("When have you felt the Holy Ghost this month?");
        _DW_prompts.Add("Who are some of your personal heroes?");
    }

    public override void Run(int DW_seconds) {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_DW_prompts[_DW_myUI.GetRandom(_DW_prompts.Count - 1)]} ---");

        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Write("\n> ");

        DateTime DW_stopTime = DateTime.Now.AddSeconds(DW_seconds);
        string DW_response = "";
        int DW_responses = 0;

        // Let the timer count down while still typing so that it will end even if it takes forever to think of the last one
        while (DW_stopTime > DateTime.Now) {
            if (Console.KeyAvailable) {
                ConsoleKeyInfo DW_keyInfo = Console.ReadKey(true);

                if (DW_keyInfo.Key == ConsoleKey.Enter) {
                    if (DW_response.Length > 0) {
                        Console.Write("\n> ");
                        DW_response = "";
                        DW_responses++;
                    }
                } else if (DW_keyInfo.Key == ConsoleKey.Backspace) {
                    if (DW_response.Length > 0) {
                        DW_response = DW_response.Remove(DW_response.Length - 1);
                        Console.Write("\b \b");
                    }
                } else {
                    DW_response += DW_keyInfo.KeyChar;
                    Console.Write($"{DW_keyInfo.KeyChar}");
                }
            }
        }

        // clear last unfinished response
        for (int i = 0; i < DW_response.Length; i++) {
            Console.Write("\b \b");
        }        
        Console.WriteLine($"\b\b  \b\bYou listed {DW_responses} items!"); // Clear last unfinished arrow and display total number
    }
}
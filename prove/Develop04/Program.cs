using System;

/*

Creativity:

I added custom 'Spinners' for each activity
I also made it not pick the same question twice in the Reflecting Activity
I also made it so that in the Listing Activity while typing the responses, the program is still constantly checking the time left
    instead of waiting to see if the time ran out after the last response was entered.

*/

class Program {
    static MyUI DW_myUI = new MyUI();
    static List<Activity> DW_activities = new List<Activity>();

    static void Main(string[] args) {
        DW_activities.Add(new BreathingAct());
        DW_activities.Add(new ReflectingAct());
        DW_activities.Add(new ListingAct());
        
        int DW_choice;
        int DW_seconds;
        Activity DW_activity;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        while((DW_choice = DisplayMenu()) != 0) { // Display menu, get response, store response, and test response all in one line
            DW_activity = DW_activities[DW_choice - 1];
            Console.Clear();
            Console.WriteLine("Get ready...");
            DW_activity.Spinner(4, 50);

            Console.Clear();
            DW_activity.StartMessage();
            DW_seconds = DW_myUI.PromptInt("How long, in seconds, would you like for your session? ");

            Console.Clear();
            Console.Write("Get Ready... ");
            DW_activity.CountDown(3);
            
            Console.WriteLine("\n"); // double space
            DW_activity.Run(DW_seconds);

            DW_activity.EndMessage(DW_seconds);
            DW_activity.Spinner(6, 50);

            Console.Clear();
        }
        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }

    static int DisplayMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("0. Quit"); // I put quit as 0 so that more activities can easily be added later
        return DW_myUI.PromptInt("Select a choice from the menu: ", [0, 1, 2, 3]);
    }
}
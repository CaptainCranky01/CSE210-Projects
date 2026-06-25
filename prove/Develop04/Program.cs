using System;

class Program {
    static MyUI DW_myUI = new MyUI();
    static List<Activity> activities = new List<Activity>();

    static void Main(string[] args) {
        activities.Add(new BreathingAct());
        activities.Add(new ReflectingAct());
        activities.Add(new ListingAct());
        
        int DW_choice;
        Activity activity;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        while((DW_choice = DisplayMenu()) != 0) {
            Console.Clear();
            activity = activities[DW_choice];
            activity.Spinner(10, 500);
        }
        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }

    static int DisplayMenu() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("0. Quit");
        return DW_myUI.PromptInt("Select a choice from the menu: ", [0, 1, 2, 3]);
    }
}
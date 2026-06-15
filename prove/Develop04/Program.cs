using System;

class Program {
    static MyUI DW_myUI = new MyUI();
    static BreathingAct breathingAct = new BreathingAct();
    static ReflectingAct reflectingAct = new ReflectingAct();
    static ListingAct listingAct = new ListingAct();

    static void Main(string[] args) {
        int DW_choice;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        while((DW_choice = DisplayMenu()) != 0) {
            Console.Clear();
            switch (DW_choice) {
                case 1:
                    breathingAct.Spinner(5, 500);
                    break;
                case 2:
                    Console.Write("Loading Activity: ");
                    reflectingAct.Spinner(5, 50);
                    Console.WriteLine("Done!");
                    break;
                case 3:
                    Console.Write("Loading Activity: ");
                    listingAct.Spinner(5, 500);
                    Console.WriteLine("Done!");
                    break;
                case 4:
                    Console.Write("Seconds left: ");
                    breathingAct.CountDown(10);
                    Console.WriteLine();
                    break;
            }
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
        Console.WriteLine("0. Quit");
        return DW_myUI.PromptInt("Select a choice from the menu: ", [0, 1, 2, 3]);
    }
}
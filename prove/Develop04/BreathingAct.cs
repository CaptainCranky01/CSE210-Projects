public class BreathingAct : Activity {
    public BreathingAct() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    ["| | | | | | | | | | | | | | | | | | | |", " /| | | | | | | | | | | | | | | | | | |", " / /| | | | | | | | | | | | | | | | | |",
     " / / /| | | | | | | | | | | | | | | | |", " / / / /| | | | | | | | | | | | | | | |", " / / / / /| | | | | | | | | | | | | | |",
     " / / / / / /| | | | | | | | | | | | | |", " / / / / / / /| | | | | | | | | | | | |", " / / / / / / / /| | | | | | | | | | | |",
     " / / / / / / / / /| | | | | | | | | | |", " / / / / / / / / / /| | | | | | | | | |", " / / / / / / / / / / /| | | | | | | | |",
     " / / / / / / / / / / / /| | | | | | | |", " / / / / / / / / / / / / /| | | | | | |", " / / / / / / / / / / / / / /| | | | | |",
     " / / / / / / / / / / / / / / /| | | | |", " / / / / / / / / / / / / / / / /| | | |", " / / / / / / / / / / / / / / / / /| | |",
     " / / / / / / / / / / / / / / / / / /| |", " / / / / / / / / / / / / / / / / / / /|", " / / / / / / / / / / / / / / / / / / /__",
     " / / / / / / / / / / / / / / / / / / /__", " / / / / / / / / / / / / / / / / / / /__", " / / / / / / / / / / / / / / / / / / /__"]) {
        
    }

    public override void Run(int DW_seconds) {
        for (int i = 0; i < DW_seconds / 10; i++) {
            Console.Write("\n\nBreath in... ");
            CountDown(4);
            Console.Write("\nNow breath out... ");
            CountDown(6);
        }
    }
}
public class ReflectingAct : Activity {
    private List<string> _DW_prompts;
    private List<string> _DW_subPrompts;
    
    public ReflectingAct() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    ["oooooooooooooooooooo", "0ooooooooooooooooooo", "00oooooooooooooooooo", "000ooooooooooooooooo", "0000oooooooooooooooo",
     "00000ooooooooooooooo", "o00000oooooooooooooo", "oo00000ooooooooooooo", "ooo00000oooooooooooo", "oooo00000ooooooooooo",
     "ooooo00000oooooooooo", "oooooo00000ooooooooo", "ooooooo00000oooooooo", "oooooooo00000ooooooo", "ooooooooo00000oooooo",
     "oooooooooo00000ooooo", "ooooooooooo00000oooo", "oooooooooooo00000ooo", "ooooooooooooo00000oo", "oooooooooooooo00000o",
     "ooooooooooooooo00000", "oooooooooooooooo0000", "ooooooooooooooooo000", "oooooooooooooooooo00", "ooooooooooooooooooo0",
     "oooooooooooooooooooo", "oooooooooooooooooooo", "oooooooooooooooooooo", "oooooooooooooooooooo", "oooooooooooooooooooo"]) {
        _DW_prompts = new List<string>();
        _DW_subPrompts = new List<string>();
        
        _DW_prompts.Add("Think of a time when you stood up for someone else.");
        _DW_prompts.Add("Think of a time when you did something really difficult.");
        _DW_prompts.Add("Think of a time when you helped someone in need.");
        _DW_prompts.Add("Think of a time when you did something truly selfless.");
        
        _DW_subPrompts.Add("Why was this experience meaningful to you?");
        _DW_subPrompts.Add("Have you ever done anything like this before?");
        _DW_subPrompts.Add("How did you get started?");
        _DW_subPrompts.Add("How did you feel when it was complete?");
        _DW_subPrompts.Add("What made this time different than other times when you were not as successful?");
        _DW_subPrompts.Add("What is your favorite thing about this experience?");
        _DW_subPrompts.Add("What could you learn from this experience that applies to other situations?");
        _DW_subPrompts.Add("What did you learn about yourself through this experience?");
        _DW_subPrompts.Add("How can you keep this experience in mind in the future?");
    }

    public override void Run(int DW_seconds) {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {_DW_prompts[_DW_myUI.GetRandom(_DW_prompts.Count - 1)]} ---");
        _DW_myUI.PromptString("When you have something in mind, press enter to continue.");

        Console.WriteLine("\nNow ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);

        Console.Clear();

        List<string> DW_unpickedQuestions = _DW_subPrompts;

        for (int i = 0; i < DW_seconds / 10; i++) {
            int DW_index = _DW_myUI.GetRandom(DW_unpickedQuestions.Count);
            Console.WriteLine($"{DW_unpickedQuestions[DW_index]}");
            DW_unpickedQuestions.RemoveAt(DW_index);
            Spinner(10, 100);
            if (DW_unpickedQuestions.Count == 0) break;
        }
    }
}
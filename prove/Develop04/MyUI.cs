public class MyUI {
    private Random DW_rand = new Random();

    public int GetRandom() {
        return DW_rand.Next(0, 10);
    }
    public int GetRandom(int max) {
        return DW_rand.Next(0, max);
    }
    public int GetRandom(int min, int max) {
        return DW_rand.Next(min, max);
    }

    public int PromptInt(string DW_prompt, List<int> DW_valid = null) {
        bool DW_flag = true;
        int DW_response = 0;

        do {
            Console.Write(DW_prompt);
            try {
                DW_response = int.Parse(Console.ReadLine());
                // If a specific list of valid responses was provided then make sure the response is one of those things
                if (DW_valid != null && !DW_valid.Contains(DW_response)) {
                    throw new Exception();
                }
                DW_flag = false;
            } catch {
                Console.WriteLine($"Invalid Response!");
            }
        } while(DW_flag);
        return DW_response;
    }

    public string PromptString(string DW_prompt) {
        Console.Write(DW_prompt);
        return Console.ReadLine();
    }
}
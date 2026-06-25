public abstract class Activity {
    protected MyUI _DW_myUI = new MyUI();
    private string _DW_name;
    private string _DW_description;
    private List<string> _DW_spinSeq;

    public Activity(string DW_name, string DW_description, List<string> DW_spinSeq = null) {
        _DW_name = DW_name;
        _DW_description = DW_description;
        _DW_spinSeq = DW_spinSeq;
    }

    public abstract void Run(int DW_seconds);

    public void StartMessage() {
        Console.WriteLine($"Welcome to the {_DW_name}.\n\n{_DW_description}\n");
    }

    public void EndMessage(int DW_seconds) {
        Console.WriteLine($"\nWell done!\n\nYou have completed another {DW_seconds} seconds of the {_DW_name}");
    }

    public void Spinner(int DW_seconds, int DW_freq) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(DW_seconds);
        while(DateTime.Now < endTime) {
            for (int i = 0; i < _DW_spinSeq.Count; i++) {
                Console.Write(_DW_spinSeq[i]);
                Thread.Sleep(DW_freq);
                Console.Write(new string('\b', _DW_spinSeq[i].Length)); // go back
                Console.Write(new string(' ', _DW_spinSeq[i].Length)); // clear
                Console.Write(new string('\b', _DW_spinSeq[i].Length)); // go back again
            }
        }
    }

    public void CountDown(int DW_seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(DW_seconds);
        while(DateTime.Now < endTime) {
            string currentSecond = $"{(int)(endTime - DateTime.Now).TotalSeconds + 1}";
            Console.Write(currentSecond);
            Thread.Sleep(1000);
            Console.Write(new string('\b', currentSecond.Length)); // go back
            Console.Write(new string(' ', currentSecond.Length)); // clear
            Console.Write(new string('\b', currentSecond.Length)); // go back again
        }
    }
}
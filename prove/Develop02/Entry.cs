public class Entry
{
    public string _DW_entryPrompt;
    public string _DW_entryText;
    public DateTime _DW_entryTime;

    public void Display()
    {
        Console.WriteLine($"{_DW_entryTime} - {_DW_entryPrompt}\n{_DW_entryText}\n");
    }
}
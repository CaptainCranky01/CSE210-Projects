public class Entry
{
    public string _entryPrompt;
    public string _entryText;
    public DateTime _entryTime;

    public void Display()
    {
        Console.WriteLine($"{_entryTime} - {_entryPrompt}\n{_entryText}\n");
    }
}
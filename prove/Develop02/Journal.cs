using System.IO.Enumeration;

public class Journal
{
    public string _fileName;
    public List<Entry> _journalEntries = new List<Entry>();

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry journalEntry in _journalEntries)
            {
                outputFile.WriteLine($"{journalEntry._entryTime},{journalEntry._entryPrompt},{journalEntry._entryText}");
            }
        }
    }

    public void LoadFile()
    {
        try {
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            _journalEntries.Clear();

            foreach (string line in lines)
            {
                string[] lineParts = line.Split(",");
                DateTime entryTime = DateTime.Parse(lineParts[0]);
                string entryPrompt = lineParts[1];
                string entryText = lineParts[2];
                AddEntry(entryTime, entryPrompt, entryText);
            }
        } catch(Exception e)
        {
            Console.WriteLine("Could not find the specified file!");
        }
    }

    public void Display()
    {
        if (_journalEntries.Count == 0)
        {
            Console.WriteLine("NO ENTRIES FOUND");
        }
        foreach (Entry journalEntry in _journalEntries)
        {
            journalEntry.Display();
        }
    }

    public void AddEntry(DateTime entryTime, string entryPrompt, string entryText)
    {
        Entry newEntry = new Entry();
        newEntry._entryTime = entryTime;
        newEntry._entryPrompt = entryPrompt;
        newEntry._entryText = entryText;
        _journalEntries.Add(newEntry);
    }
}
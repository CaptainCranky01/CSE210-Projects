using System.IO.Enumeration;

public class Journal
{
    public string _DW_fileName;
    public List<Entry> _DW_journalEntries = new List<Entry>();

    public void SaveFile()
    {
        using (StreamWriter DW_outputFile = new StreamWriter(_DW_fileName))
        {
            foreach (Entry DW_journalEntry in _DW_journalEntries)
            {
                DW_outputFile.WriteLine($"{DW_journalEntry._DW_entryTime},{DW_journalEntry._DW_entryPrompt},{DW_journalEntry._DW_entryText}");
            }
        }
    }

    public void LoadFile()
    {
        try {
            string[] DW_lines = System.IO.File.ReadAllLines(_DW_fileName);
            _DW_journalEntries.Clear();

            foreach (string DW_line in DW_lines)
            {
                string[] DW_lineParts = DW_line.Split(",");
                DateTime DW_entryTime = DateTime.Parse(DW_lineParts[0]);
                string DW_entryPrompt = DW_lineParts[1];
                string DW_entryText = DW_lineParts[2];
                AddEntry(DW_entryTime, DW_entryPrompt, DW_entryText);
            }
        } catch(Exception e)
        {
            Console.WriteLine("Could not find the specified file!");
        }
    }

    public void Display()
    {
        if (_DW_journalEntries.Count == 0)
        {
            Console.WriteLine("NO ENTRIES FOUND");
        }
        foreach (Entry journalEntry in _DW_journalEntries)
        {
            journalEntry.Display();
        }
    }

    public void AddEntry(DateTime entryTime, string entryPrompt, string entryText)
    {
        Entry newEntry = new Entry();
        newEntry._DW_entryTime = entryTime;
        newEntry._DW_entryPrompt = entryPrompt;
        newEntry._DW_entryText = entryText;
        _DW_journalEntries.Add(newEntry);
    }
}
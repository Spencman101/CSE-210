using System;

class Journal 
{
    private List<string> _entries;
    private string _prompt;
    private int _wordcount;

    public Journal()
    {
        _entries = [];
    }
    public void AddEndtry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    static void DisplayAllEntries()
    {
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void WriteEntriesToFile(string _fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        return outputString;
    }
    static void ReadEntriesFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split();
        }
    }
}
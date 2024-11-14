using System;

class Journal 
{
    private List<string> _entries;
    private string _prompt;
    private int _wordcount;

    static void DisplayAllEntries()
    {
        
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

    }
}
using System;

class Entry
{
    private List<string> _prompts;
    private string _date;
    private string _entryQuestion;
    private string _journalEntry;

    public JournalEntry()
    {
        _date = "";
        _entryQuestion = "";
        _journalEntry = "";
    }
    private void CreateEntry()
    {

    }
    private string GetRandomPrompt()
    {
        Random promptGenerator = new Random();
        int random = promptGenerator.Next(0, _prompts.Count);
        return _prompts[random];
    }
    private void DateTime()
    {
        DateTime _date = DateTime.Now;
    }
    private void DisplayPrompt()
    {

    }
}
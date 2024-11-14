using System;

class Entry
{
    private List<string> _prompts;
    private DateTime _date;

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
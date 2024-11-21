using System;

class Program
{
    private static string _fileName;
    
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        Console.WriteLine("Hello Develop02 World!");
        GetFileName();
        _fileName = Console.ReadLine();
        DisplayMenu();
    }
    public void GetSelection()
    {
        int _selection = 0;
        while (_selection != 5)
        {
            DisplayMenu();
            _selection = (int.Parse(Console.ReadLine()));
            if (_selection == 1)
            {
                JournalEntry journalEntry = new JournalEntry();
                string question = journalQuestions.NextQuestion();
                journalEntry.CreateEntry(question);

                journalEntry.Display();

                newJournal.AddEndtry(journalEntry);
            }
            else if (_selection == 2)
            {
                newJournal.Display();
            }
            else if (_selection == 3)
            {
                string filename = GetFileName();
            }
            else
            {
                break;
            }
        }
    }
    static void GetFileName()
    {
        Console.Write("What is the name of your journal file? ");
    }
    static void DisplayMenu()
    {
        Console.Write("Please select one of the following chocies:\n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
    }
}
using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = "";
        _verse = "";
        _startVerse = 0;
        _endVerse = 0;
    }
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}, {_verse}:");    
    }
    private void Create_reference()
    {
        _book = "John";
        _chapter = "3";
        _verse = "16";
        _startVerse = 16;
        _endVerse = 16;
    }
}
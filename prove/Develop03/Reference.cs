using System;

class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string reference)
    {
        ParseReference(reference);
    }
    public string Display()
    {
        if (this._endVerse != -1)
        {
            return _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
        }
        else {
            return _book + " " + _chapter + ":" + _startVerse;
        }
    }

    // john 3:16
    private void ParseReference(string reference)
    {
        List<string> parser = reference.Split(' ').ToList<string>();
        _book = parser[0];
        parser = parser[1].Split(':').ToList<string>();
        _chapter = parser[0];
        if (parser[1].Contains('-'))
        {
            parser = parser[1].Split('-').ToList<string>();
            try {
                _startVerse = Int32.Parse(parser[0]);
                _endVerse = Int32.Parse(parser[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse dummy!");
            }
        }
        else 
        {
            try {
                _startVerse = Int32.Parse(parser[1]);
                _endVerse = -1;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse dummy!");
            }
        }

    }
}
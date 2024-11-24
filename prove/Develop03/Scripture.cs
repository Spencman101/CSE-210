using System;
using System.Text;

class Scripture
{
    private string _scripture;
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string scripture, string reference)
    {   
        _words = new List<Word>();
        _scripture = scripture;
        ParseScripture();
        _reference = new Reference(reference);
    }

    public void hide_words()
    {
        Random random = new Random();
        int selected_index = random.Next(0,_words.Count);
        _words[selected_index].SetHidden(true);
    }
    public Boolean AllWordsHidden()
    {
        foreach (Word Word in _words)
        {
            if (Word.GetHidden() == false)
            { 
                return false;
            }
        }
        return true;
    }

    public string DisplayScripture()
    {
        var forDisplay = new StringBuilder();
        for (int i = 0; i < _words.Count; i++)
        {
            forDisplay.Append(_words[i].GetWord());
            if (i < _words.Count - 1)
                forDisplay.Append(" ");
        }
        return forDisplay.ToString();
    }

    public string DisplayReference()
    {
        return _reference.Display();
    }

    private void ParseScripture()
    {
        var _unpunctuated = new StringBuilder();
        foreach (char c in _scripture)
        {
            if (!char.IsPunctuation(c))
                _unpunctuated.Append(c);
        }
        List<string> temp = _unpunctuated.ToString().Split(" ").ToList<string>();
        foreach (string w in temp)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }
}
using System;

class Word
{
    private string _word;
    private string _blank;
    private Boolean _hidden;

    public Word(string word)
    {
        _word = word;
        _blank = new String('_', _word.Length);
        _hidden = false;
    }
    public string GetWord() 
    { 
        if (_hidden == true)
            return _blank;
        return _word; 
    }
    public Boolean GetHidden() { return _hidden; }
    public void SetWord(string word) { _word = word; }
    public void SetHidden(Boolean hidden) { _hidden = hidden; }
    public void SetBlank(string blank) { _blank = blank; }

}   
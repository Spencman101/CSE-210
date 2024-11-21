using System;

class Word
{
    private string _word;
    private string _blank;
    private Boolean _hidden;

    public Word()
    {
        _word = "";
        _blank = "_____";
        _hidden = false;
    }
    private void word_selector()
    {
        Random wordGenerator = new Random();
        int selected_word = wordGenerator.Next(0,Scripture._scripture);
    }
    private void hide_word()
    {

    }
    private void isHidden()
    {

    }
}
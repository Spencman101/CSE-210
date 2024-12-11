using System;

class Video
{
    public string _title;

    public string _author;

    public int _seconds;

    public List<string> Comments;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        List<string> comments;
        comments = new List<string>();
    }
    
    public void StoreComments(Comment com)
    {
        comments.Add(com);
    }

    public void DisplayComments()
    {

    }
}
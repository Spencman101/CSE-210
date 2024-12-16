using System;

class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comments;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>();
    }

    public void StoreComments(Comment com)
    {
        _comments.Add(com);
    }

    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._commenter}: {comment._text}");
        }
    }
}
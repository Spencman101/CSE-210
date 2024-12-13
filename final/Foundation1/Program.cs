using System;

class Program
{
    public List<Video> Videos;

    static Video video;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        CreateVideo();
        CreateComment();
        
    }

    public void DisplayVideo()
    {
        foreach (var video in Videos)
        {
            Console.WriteLine(video);
        }
    }

    public static void CreateComment()
    {
        Comment com1 = new Comment();
        com1._commenter = "PixelPirate42";
        com1._text = "This video is like a treasure map! I keep finding gems every time I rewatch it!";
        video.StoreComments(com1);

        Comment com2 = new Comment();
        com2._commenter = "BananaramaKing";
        com2._text = "Why isn’t anyone talking about the random banana at 3:42? Absolute gold.";

        Comment com3 = new Comment();
        com3._commenter = "QuantumKoala99";
        com3._text = "The editing on this video is smoother than my attempts at parallel parking.";

    }

    public static void CreateVideo()
    {
        video = new Video("The Science of Black Holes Explained", "AstroNerd101", 720);
    }
}
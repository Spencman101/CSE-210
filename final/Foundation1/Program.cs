using System;

class Program
{
    public static List<Video> Videos = new List<Video>();

    static Video video;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        CreateVideo();
        CreateComment();
        DisplayVideo();
        
    }

    public static void DisplayVideo()
    {
        foreach (var video in Videos)
        {
            Console.WriteLine($"Title: {video._title}, Author: {video._author}, Duration: {video._seconds} seconds");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }

    public static void CreateComment()
    {
        Comment com1 = new Comment { _commenter = "PixelPirate42", _text = "This video is like a treasure map! I keep finding gems every time I rewatch it!" };
        Comment com2 = new Comment { _commenter = "BananaramaKing", _text = "Why isn’t anyone talking about the random banana at 3:42? Absolute gold." };
        Comment com3 = new Comment { _commenter = "QuantumKoala99", _text = "The editing on this video is smoother than my attempts at parallel parking." };
        Comment com4 = new Comment { _commenter = "GoblinMode47", _text = "This is exactly the chaotic energy I aspire to in my daily life." };
        Comment com5 = new Comment { _commenter = "PlutoPalsForever", _text = "Can we just agree Pluto is still a planet? Also, great video!" };
        Comment com6 = new Comment { _commenter = "LlamaDrama2024", _text = "That transition at 2:15 deserves an Oscar. Absolutely legendary." };
        Comment com7 = new Comment { _commenter = "AstroToast33", _text = "Space? Time? Who cares? This video transcends them all." };
        Comment com8 = new Comment { _commenter = "GlitchGoblin00", _text = "I feel like this video just upgraded my brain’s RAM." };
        Comment com9 = new Comment { _commenter = "CatNapChampion", _text = "I was going to take a nap, but then I got sucked into this masterpiece instead." };

        if (Videos.Count >= 3)
        {
            Videos[0].StoreComments(com1);
            Videos[0].StoreComments(com2);
            Videos[0].StoreComments(com3);

            Videos[1].StoreComments(com4);
            Videos[1].StoreComments(com5);
            Videos[1].StoreComments(com6);

            Videos[2].StoreComments(com7);
            Videos[2].StoreComments(com8);
            Videos[2].StoreComments(com9);
        }
    }

    public static void CreateVideo()
    {
        Videos.Add(new Video("The Science of Black Holes Explained", "AstroNerd101", 720));
        Videos.Add(new Video("10 Easy Recipes for Beginners", "ChefInTraining", 480));
        Videos.Add(new Video("A Day in the Life of a Marine Biologist", "OceanExplorer", 900));
    }
}
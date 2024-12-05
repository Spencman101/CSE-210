using System;

class ListingActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you list positive things in your life.");
        Console.Write("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        SpinnerAnimation(3);

        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        CountdownAnimation(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items. Well done!");
        SpinnerAnimation(3);
    }

    private void SpinnerAnimation(int seconds)
    {
        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b-");
            Thread.Sleep(100);
            Console.Write("\b\\");
            Thread.Sleep(100);
            Console.Write("\b|");
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    private void CountdownAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

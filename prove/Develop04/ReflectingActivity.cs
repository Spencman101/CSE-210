using System;

class ReflectingActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What could you learn from this experience that applies to other situations?"
    };

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times of strength and resilience.");
        Console.Write("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        SpinnerAnimation(3);

        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[random.Next(questions.Count)]);
            SpinnerAnimation(5);
        }

        Console.WriteLine("Well done! You have completed the Reflection Activity.");
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
}

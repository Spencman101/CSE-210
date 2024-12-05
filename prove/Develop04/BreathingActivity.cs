using System;

class BreathingActivity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by pacing your breathing.");
        Console.Write("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        SpinnerAnimation(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            CountdownAnimation(4);
            Console.WriteLine("Breathe out...");
            CountdownAnimation(4);
        }

        Console.WriteLine("Well done! You have completed the Breathing Activity.");
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

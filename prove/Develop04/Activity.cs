using System;

public class Activity 
{
    public static void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
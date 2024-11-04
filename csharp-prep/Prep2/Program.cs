using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage grade did you recieve for your course? ");
        int score = int.Parse(Console.ReadLine());
        
        if (score >= 90)
            string letter = "A"
            // Console.WriteLine("The grade you recieved was an A.");
        else if (score >= 80)
            Console.WriteLine("The grade you recieved was an B.");
        else if (score >= 70)
            Console.WriteLine("The grade you recieved was an C.");
        else if (score >= 60)
            Console.WriteLine("The grade you recieved was an D.");
        else
            Console.WriteLine("The grade you recieved was an F.");
        Console.WriteLine($"The grade you recieved was an {letter}");

        if (score >= 70)
            Console.WriteLine("Congratulations, you passed the class!");
        else
            Console.WriteLine("Unfortunately you did not pass, good luck next time!");
    }
}
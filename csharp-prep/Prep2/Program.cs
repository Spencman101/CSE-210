using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage grade did you recieve for your course? ");
        int score = int.Parse(Console.ReadLine());

        string letter = "";        
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"The grade you recieved was an {letter}");    

        if (score >= 70)
            Console.WriteLine("Congratulations, you passed the class!");
        else
            Console.WriteLine("Unfortunately you did not pass, good luck next time!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Random magicGenerator = new Random();
        string play;
        do
        {
            int magic_num = magicGenerator.Next(1,101);
            int guess;
            int guesses = 0;
            int final_guesses;
            do
            {
                Console.Write("What is your guess? ");
                final_guesses = guesses++;
                guess = int.Parse(Console.ReadLine());
                if (guess < magic_num)
                    Console.WriteLine("Higher");
                else if (guess > magic_num)
                    Console.WriteLine("Lower");
                else
                    Console.WriteLine($"You guessed it! It took you {final_guesses} guesses.");
            }while (guess != magic_num);
            Console.WriteLine("Do you want to play again? (yes or no) ");
            play = Console.ReadLine();
        }while (play == "yes");
    }
}
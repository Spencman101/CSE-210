using System;

class Program
{
    // In C# every program needs an entry point, void is the return type of the function (void = none), Static means that the function can be called without an objects assosiation, Public is repository permissions
    static void Main(string[] args)
    {
        Console.WriteLine("Input your age: "); 
        // Dont want to do this, as cursor is on the next line
        Console.Write("Input your age: "); 
        // Console.Write puts the cursor on the same line as it should
        // Console.Read goes one character at a time
        
        // string userInput = Console.ReadLine();
        // int age = int.Parse(userInput);

        int age = int.Parse(Console.ReadLine());
        // Variable types must be declared, they cannot change from their type in C#
        // Prase takes a string and turns it into an integer

        Console.WriteLine($"Your age is: {age}");
        // Console.WriteLine("Hello Sandbox World!");

        // int x = 10;

        // if (x > 15)
        // {
        //     Console.WriteLine("Hey Bob");
        // }
    }
}
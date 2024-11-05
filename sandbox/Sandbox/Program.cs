using System;
using System.Runtime.CompilerServices;

class Program
{
    // In C# every program needs an entry point, void is the return type of the function (void = none), Static means that the function can be called without an objects assosiation and Nonstatic, Public is repository permissions
    static int AddNumbers(int n1, int n2)
        {
            int total = n1 + n2;
            int total2 = n1 * n2;
            // Only 1 variable can be returned in C#
            return total;
        }
    static void Main(string[] args)
    {

        // int total = AddNumbers(20, 30);
        // Console.WriteLine(total);
        // int x = 10;
        // int y = x++;
        // Console.WriteLine($"{y}, {x}");
        // There is a difference between the pluses before or after a variable in some instances.
        // int z = ++y;
        // Console.WriteLine($"{z}, {y}");

        // Console.WriteLine("Input your age: "); 
        // Dont want to do this, as cursor is on the next line
        // Console.Write("Input your age: "); 
        // Console.Write puts the cursor on the same line as it should
        // Console.Read goes one character at a time
        
        // string userInput = Console.ReadLine();
        // int age = int.Parse(userInput);

        // int age = int.Parse(Console.ReadLine());
        // Variable types must be declared, they cannot change from their type in C#
        // Prase takes a string and turns it into an integer

        // Console.WriteLine($"Your age is: {age}");
        // Console.WriteLine("Hello Sandbox World!");

        // int x = 10;

        // if (x > 15)
        // {
        //     Console.WriteLine("Hey Bob");
        // }

        // 11/4 In-Class
        // First part is variable declaration and happens only once, Next is loop condition (conditional) after this it executes the loop, and last is done at the end of the loop and it checks the conditional to see if the loop will run again.
        // for(int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while (age < 0 || age > 125)
        // {
        //     Console.Write("Please enter your age: (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }

        // Must be declared before do while loop as it would only exist in the loop and couldn't carry out to while loop as it is outside the code block.
        // int age;
        // Do while loops are garunteed to be executed once, so you dont need a entrance strategy (Dont Need age = 1)
        // do
        // {
        //     Console.Write("Please enter your age: (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }while (age < 0 || age > 125);

        // List <string> myColors = new List<string>();

        // myColors.Add("Red");
        // myColors.Add("Green");
        // myColors.Add("Blue");

        // foreach(string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }

    }
}
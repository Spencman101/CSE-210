using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int highest_num = 0;
        int smallest_pos = 100;
        int sum = 0;
        double average = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }while (numbers.Contains(0) == false);
        numbers.RemoveAt(numbers.Count - 1);
        foreach (int number in numbers)
        {
            if (number > highest_num)
            {
                highest_num = number;
            }
            else if (number < smallest_pos && number > 0)
            {
                smallest_pos = number;
            }
            sum += number;
        }
        average = (double)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum} \nThe average is: {average} \nThe largest number is: {highest_num} \n The smallest positive number is: {smallest_pos}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
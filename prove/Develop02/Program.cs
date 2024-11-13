using System;

class Program
{
    private string fileName;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
    static void GetSelection()
    {
        int selection;
        do
        {
            selection = (int.Parse(Console.ReadLine()));
        }while (selection != 5);
    }
    static void GetFileName()
    {
        
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following chocies:\n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
    }
}
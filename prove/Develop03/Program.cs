using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean quitProgram = false;
        string script = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string refer = "John 3:16";
        Scripture scripture = new Scripture(script, refer);
        Console.WriteLine(scripture.DisplayReference());
        Console.WriteLine(scripture.DisplayScripture());
        Console.Write("Press enter to hide words in the scripture, or type 'quit' to exit program.");
        do
        {
            if ((Console.ReadLine() == "quit") || (scripture.AllWordsHidden() == true))
            {
                quitProgram = true;
            }
            for (int i = 0; i < 3; i++)
            {
                scripture.hide_words();
            }
            Console.Clear();
            Console.WriteLine(scripture.DisplayReference());
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("Press enter to hide words in the scripture, or type 'quit' to exit program.");
        }while (!quitProgram);
        Console.Clear();
    }
}
    
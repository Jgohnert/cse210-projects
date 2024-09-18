using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6); 
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. in all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);
        DisplayScripture(scripture);

        Random random = new Random();

        while (!scripture.AllHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string userInput = Console.ReadLine();
            
            scripture.HideWords(random);
            Console.Clear();
            DisplayScripture(scripture);

            if (userInput == "quit")
            {
                break;
            }
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetReference());
        Console.WriteLine(scripture.GetText());
    }
}

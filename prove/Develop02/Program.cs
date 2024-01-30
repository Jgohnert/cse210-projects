using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        bool entriesLoaded = false;

        int chosenNumber = 0;
        Journal journal = new Journal();
        List<Entry> loadedEntries = new List<Entry>();

        Console.WriteLine("Welcome to the Journal Program!");

        while (chosenNumber != 5)
        {
            Console.Write(
@"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ");
            
            string userChoice = Console.ReadLine();
            chosenNumber = int.Parse(userChoice);

            if (chosenNumber == 1)
            {
                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                Prompt prompts = new Prompt();
                string promptOfTheDay = prompts.RandomPrompt();

                Console.WriteLine($"Prompt: {promptOfTheDay}");
                Console.Write("Entry: ");
                string userEntry = Console.ReadLine();

                journal._entryList.Add(new Entry{_userEntry = userEntry, _date = dateText, _onePrompt = promptOfTheDay});

            }

            else if (chosenNumber == 2)
            {

                if (entriesLoaded)
                {
                    foreach (Entry loadedEntry in loadedEntries)
                    {
                        loadedEntry.Display();
                    }
                }

                foreach (Entry entry in journal._entryList)
                {
                    entry.Display();
                }
            }

            else if (chosenNumber == 3)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();

                List<Entry> entriesFromFile = journal.LoadFromFile(fileName);
                loadedEntries.AddRange(entriesFromFile);

                entriesLoaded = true;
            }

            else if (chosenNumber == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
            
                List<Entry> saveEntries = new List<Entry>();
                saveEntries.AddRange(loadedEntries);
                saveEntries.AddRange(journal._entryList);
            
                journal.SaveFile(fileName, saveEntries);
            }

            else if (chosenNumber == 5)
            {
                Console.WriteLine("Good job using the Journal Program today!");
                break;
            }
        }
    }
}
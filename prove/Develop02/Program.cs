using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        bool entriesLoaded = false;
        int chosenNumber = 0;

        Journal journal = new Journal();
        List<Entry> loadEntries = new List<Entry>();

        Console.WriteLine("Welcome to your Journal Program!");

        while (chosenNumber != 6)
        {
            Console.Write(
@"Please select one of the following choices:
1. Write
2. Display
3. Search
4. Load
5. Save
6. Quit
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
                    foreach (Entry loadEntry in loadEntries)
                    {
                        loadEntry.Display();
                    }
                }

                foreach (Entry entry in journal._entryList)
                {
                    entry.Display();
                }
            }

            //Below is the code I added. It displays an entry or entries that the user can search by date.
            //it works by taking the user's searched date to convert it into DateTime so it can be compareed 
            //to the iterated list of loaded entries. This will allow the program to find and display the date 
            //with the corresponding entry that the user is looking for.
            else if (chosenNumber == 3)
            {
                Console.Write("Enter the date of the entry you want to find (MM/DD/YYYY): ");
                string searchDate = Console.ReadLine();

                if (DateTime.TryParse(searchDate, out DateTime searchedDate))
                {
                    List<Entry> entriesSearched = new List<Entry>();

                    foreach (Entry loadEntry in loadEntries)
                    {
                        if (loadEntry._date == searchedDate.Date.ToShortDateString())
                        {
                            entriesSearched.Add(loadEntry);
                        }
                    }

                    foreach (Entry displaySearch in entriesSearched)
                    {
                        displaySearch.Display();
                    }
                }

                else
                {
                    Console.WriteLine("Error.");
                }
            }

            else if (chosenNumber == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();

                List<Entry> entriesFromFile = journal.LoadFromFile(fileName);
                loadEntries.AddRange(entriesFromFile);

                entriesLoaded = true;
            }

            else if (chosenNumber == 5)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
            
                List<Entry> saveEntries = new List<Entry>();
                saveEntries.AddRange(loadEntries);
                saveEntries.AddRange(journal._entryList);
            
                journal.SaveToFile(fileName, saveEntries);
            }

            else if (chosenNumber == 6)
            {
                Console.WriteLine("Good job using the Journal Program today!");
                break;
            }

            else if (chosenNumber > 6 || chosenNumber < 1)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
using System.IO; 
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void SaveToFile(string fileName, List<Entry> entriesToSaved)
{
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        Console.WriteLine("File saved.");
        foreach (Entry entry in entriesToSaved)
        {
            outputFile.WriteLine($"{entry._date}~{entry._onePrompt}~{entry._userEntry}");
        }
    }
}

    public List<Entry> LoadFromFile(string fileName)
    {
        Console.WriteLine("Journal successfully loaded");
        List<Entry> savedJournal = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] values = lines[i].Split('~');

            if (values.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = values[0],
                    _onePrompt = values[1],
                    _userEntry = values[2]
                };
                savedJournal.Add(entry);
            }
        }
        return savedJournal;
    }
}
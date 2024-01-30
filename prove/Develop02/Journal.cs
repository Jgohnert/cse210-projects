using System.IO; 
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void SaveFile(string fileName, List<Entry> entriesToSave)
    {
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        foreach (Entry entry in entriesToSave)
        {
            outputFile.WriteLine(
$@"Prompt: {entry._onePrompt}
Date: {entry._date}
Entry: {entry._userEntry}");
        }
    }
    }

    public List<Entry> LoadFromFile(string fileName)
    {
        Console.WriteLine("Journal");
        List<Entry> savedJournal = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i += 3)
    {
        if (i + 2 < lines.Length)
        {
            Entry entry = new Entry
            {
                _onePrompt = lines[i + 0].Substring(8),
                _date = lines[i + 1].Substring(5),
                _userEntry = lines[i + 2].Substring(7)
            };

            savedJournal.Add(entry);
        }
    }
    
        return savedJournal;
    }


}
public class Entry
{
    public string _userEntry = "";
    public string _date = "";
    public string _onePrompt = "";

    public void Display()
    {
        Console.WriteLine(
$@"Prompt: {_onePrompt}
Date: {_date}
Entry: {_userEntry}");
    }
}
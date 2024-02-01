public class Prompt
{
    public List<string> _prompts = new List<string> 
    {
        "What was an act of service you did today?", 
        "What was an act of service someone did for you today?", 
        "What was one thing that made you smile today?", 
        "What is something that you are grateful for today?",
        "Did you use any of your talents today?",
        "What was your favorite activity today?",
    };
    public Random random = new Random();
    
    public string RandomPrompt()
    {

        int randomString = random.Next(0, 5);
        
        return _prompts[randomString];
    }
}
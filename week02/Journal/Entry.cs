
public class Entry
{
    public string _date;
    public string _txPrompt;
    public string _txEntry;

    public Entry()
    {
        
    }   

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_txPrompt}");
        Console.WriteLine($"{_txEntry}");
    } 
}
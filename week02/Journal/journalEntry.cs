using System.Runtime.CompilerServices;

public class journalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public journalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}
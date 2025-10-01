using System;
class Note
{
    private string text;
    private bool isImportant;
    public Note(string noteText)
    {
        text = noteText;
        isImportant = false;
    }
    public void MarkAsImportant()
    {
        isImportant = true;
    }
    public void Print()
    {
        string status = isImportant ? "- Yes" : "- No";
        Console.WriteLine($"Text {text}, Important {status}");
    }
    
}
class Program
{
    static void Main()
    {
        Note text_1 = new Note("Hodl BTC!");
        Note text_2 = new Note("Sell in May and go away");
        
        text_1.Print();
        text_2.Print();
        
        text_1.MarkAsImportant();
        text_1.Print();
    }
}
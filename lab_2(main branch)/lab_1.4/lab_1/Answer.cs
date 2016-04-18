using System;

public class Answer
{
    public bool Correct {get; set; }

    public string Text { get; set; }
    
    public int Number { get; set; }

    public Answer()
    {
        Text = "---";
    }
    public Answer(string text)
    {
        this.Text = text;
    }
    public Answer(string text, bool Correct)
    {
        this.Text = text;
        this.Correct = Correct;
    }

    public void Print(int j)
    {
        Console.WriteLine("    {0}. {1}", j, Text);
    }

    public void EnterAnswer()
    {
        Console.WriteLine("\nEnter the answer:");
        Text = Console.ReadLine();
    }
    public override string ToString()
    {
        return Text;
    }
}
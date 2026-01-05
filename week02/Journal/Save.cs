using System;

public class Save
{
    public Prompt prompt;

    public Save(Prompt prompt)
    {
        this.prompt = prompt;
    }

    public void SaveJournal()
    {
        System.Console.Write("Enter filename to save in your work: ");
        string filename = System.Console.ReadLine();
        System.IO.File.WriteAllLines(filename,prompt.prompts);
        Console.WriteLine($"Your journal has been saved to {filename}");
    }
}
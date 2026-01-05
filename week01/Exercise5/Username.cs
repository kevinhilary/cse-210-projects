using System;

public class Username
{
    public string PromptUserName()
    {
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
}
using System;

public class Number
{
    public int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}
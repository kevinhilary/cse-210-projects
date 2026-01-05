using System;
using System.Collections.Generic;

public class Prompt
{
    public List <string> prompts = new List<string> ();
    private List <string> questions = new List<string> ()
    {
        "Who was the most important person I interacted with today? ",
        "How did i use the hand of the lord in my life today? ",
        "What was the strongest emotion i felt today? ",
        "If i had one thing i could do over today, what would it be? ",
        "Who was the most intersting person i met today? "
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        return questions[rand.Next(questions.Count)];
    }

    public void AnswerPrompt()
    {
        string question = GetRandomPrompt();
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        prompts.Add(DateTime.Today.ToShortDateString() + "-" + question + ":" + answer);
        Console.WriteLine("Your entry has been recorded.");
    }

    public void DisplayEntries()
    {
        foreach(string prompt in prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}
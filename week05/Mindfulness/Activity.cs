// Activity.cs
using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration; // in seconds

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine($"\n--- Starting {Name} ---");
        Console.WriteLine(Description);
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine("Get ready...");
        Utils.ShowSpinner(3);
    }

    public virtual void End()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {Name} for {Duration} seconds.");
        Utils.ShowSpinner(3);
    }
}
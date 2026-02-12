// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breath.", 
               duration) { }

    public void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Utils.Countdown(4);
            elapsed += 4;
            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            Utils.Countdown(6);
            elapsed += 6;
        }
        End();
    }
}
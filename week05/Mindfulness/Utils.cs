// Utils.cs
using System;
using System.Threading;

public static class Utils
{
    public static void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int i = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[i % spinner.Length]}");
            Thread.Sleep(200);
            i++;
        }
        Console.Write("\r "); // clear spinner
    }

    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
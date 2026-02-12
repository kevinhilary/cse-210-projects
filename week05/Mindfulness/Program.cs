// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Mindfulness Program ---");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            int duration;

            switch (choice)
            {
                case "1":
                    duration = GetDuration();
                    var breathing = new BreathingActivity(duration);
                    breathing.Run();
                    break;
                case "2":
                    duration = GetDuration();
                    var reflecting = new ReflectingActivity(duration);
                    reflecting.Run();
                    break;
                case "3":
                    duration = GetDuration();
                    var listing = new ListingActivity(duration);
                    listing.Run();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static int GetDuration()
    {
        int duration;
        Console.Write("Enter duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }
        return duration;
    }
}
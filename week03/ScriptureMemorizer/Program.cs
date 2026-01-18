using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Scripture text
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";

        // Create scripture object
        Scripture scripture = new Scripture(reference, text);

        // Keep showing scripture until all words are hidden or user types quit
        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // hides 3 words each time
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        Prompt prompt = new Prompt();
        Displayy display = new Displayy(prompt);
        Save save = new Save(prompt);
        Load load = new Load();

        while (true)  // simple loop
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                prompt.AnswerPrompt();
            }
            else if (choice == "2")
            {
                display.Show();
            }
            else if (choice == "3")
            {
                save.SaveJournal();
            }
            else if (choice == "4")
            {
                load.LoadJournal();
            }
            else if (choice == "5")
            {
                break;  // exit the loop
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
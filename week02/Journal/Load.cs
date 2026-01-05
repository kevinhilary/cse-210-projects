using System;
using System.IO;

public class Load
{
    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);  // print each line to the user
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
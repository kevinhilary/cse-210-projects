using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letter = " ";

        if(gradePercentage>=90)
        {
            letter = "A";
        }
        else if(gradePercentage >= 80)
        {
            letter = "B";
        }
        else if(gradePercentage>=70)
        {
            letter = "C";   
        }
        else if(gradePercentage>=60)
        {
            letter = "D";   
        }
        else
        {
            letter = "E";
        }
        Console.WriteLine($"Grade: {letter}");


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congragulations, You passed the course!");
        }
        else
        {
            Console.WriteLine("You failed the course but you can do better next time");
        }
    }
}
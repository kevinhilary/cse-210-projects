using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int> ();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }

            double average = 0;
            if (numbers.Count > 0)
            {
                average = (double)sum/numbers.Count;
            }

            int max =numbers[0];
            foreach(int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");  
    }
}
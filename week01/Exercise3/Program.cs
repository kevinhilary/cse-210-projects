using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (magicNumber != guess)
        {
            Console.Write("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Enter a lower guess");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Enter a higher guess");
            }
            else
            {
                Console.WriteLine("You guessed right");
            }
        }
    }
}
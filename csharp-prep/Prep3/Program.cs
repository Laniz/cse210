using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1100;

        while (guess != number)
        {
            Console.WriteLine("What is the magic number?");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower,");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }

    
}

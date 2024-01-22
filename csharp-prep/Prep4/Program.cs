using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int exit_response = 0;
        int user_input = 1;

        List<int> numbers = new List<int>();

        while (exit_response != user_input)
        {
            Console.WriteLine("Enter a number: Enter 0 to exit");
            user_input = int.Parse(Console.ReadLine());


            if (user_input != 0)
            {
                numbers.Add(user_input);
            }


        }

        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}
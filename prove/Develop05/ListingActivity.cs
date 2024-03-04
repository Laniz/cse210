using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private string[] prompts = { "Who are people that you appreciate?",
                                 "What are personal strengths of yours?",
                                 "Who are people that you have helped this week?",
                                 "When have you felt the Holy Ghost this month?",
                                 "Who are some of your personal heroes?" };

    public ListingActivity(int duration) : base(duration) { }

    // Guide the user through listing items related to a specific theme
    public void DoListing()
    {
        Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("  ");
        
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"You have {duration} seconds to list as many items as you can.");
        Console.WriteLine($"Prompt: {prompt}");
        
        
        
        // Console.WriteLine("Get ready to begin...");
        // Thread.Sleep(3000); // Pause for 3 seconds to prepare
        
        // Countdown before listing items
        // Console.WriteLine("Starting in 3...");
        // Thread.Sleep(1000); // Pause for 1 second
        // Console.WriteLine("2...");
        // Thread.Sleep(1000); // Pause for 1 second
        // Console.WriteLine("1...");
        // Thread.Sleep(1000); // Pause for 1 second
        // Console.WriteLine("Start listing!");
        
        // Start listing items
        DateTime startTime = DateTime.Now;
        List<string> lines = new List<string>();
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string line = Console.ReadLine();
            lines.Add(line);

            // Update the remaining time
            TimeSpan remainingTime = TimeSpan.FromSeconds(duration - (DateTime.Now - startTime).TotalSeconds);
            
            Console.WriteLine("");

            // Thread.Sleep(5000); // Pause for 5 seconds before the next prompt
            Console.Clear();
            Console.WriteLine($"You have ({remainingTime.TotalSeconds:F2} seconds) remaining.");
            Console.WriteLine($"Prompt: {prompt}");
        }

        Console.WriteLine(" ");
        Console.WriteLine($"Well done!, Here are the Itmes you listed:");
        Console.WriteLine($"You listed {lines.Count} items:");
        foreach (string item in lines)
        {
            Console.WriteLine(item);
        }

        Finish();
    }
}

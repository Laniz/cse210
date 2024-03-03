using System;
using System.Threading;

// Listing activity class
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
        
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        
        Console.WriteLine($"You have {duration} seconds to list as many items as you can.");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds to prepare
        
        // Countdown before listing items
        Console.WriteLine("Starting in 3...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("2...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("1...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("Start listing!");
        
        // Start listing items
        DateTime startTime = DateTime.Now;
        int itemCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
             
            
            
            string promptss = prompts[rand.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {promptss}");
            Console.WriteLine($"You have ({5} seconds)\r");
            Thread.Sleep(5000);
            
            Console.WriteLine(" ");
            
        }
        
        
        Console.WriteLine($"You listed {itemCount} items.");
        
        Finish();
    }
}

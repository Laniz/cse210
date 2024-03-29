using System;
using System.Threading;
using System.Diagnostics;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
        if (duration <= 0)
        {
            throw new ArgumentException("Duration must be a positive integer.");
        }
    }



    // I tried everything I can think of to get this to work, the animation for some reason is not displaying for this class, It works for the other 2,
    // But not this one. I do no know what I am missing.

    




    public void DoBreathing()
    {           
        bool toggle = true;
        DateTime startTime = DateTime.Now;

            // DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < 5)
        {
            if (toggle)
            {
                Console.Write("|");
                
            }
            else
            {
                Console.Write("-");
            }

            toggle = !toggle;
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back to overwrite the previous character
            // stopwatch.Start();
        }













        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine(" ");
        // Thread.Sleep(3000); // Pause for 3 seconds before starting
        
        int elapsedTime = 0;
        // DateTime startTime = DateTime.Now;

        // Loop until the elapsed time equals the specified duration
        while (elapsedTime < duration)
        {
            // Breathe in
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"Breathe in... ({i} seconds)\r");
                Thread.Sleep(1000);
                elapsedTime++; // Increment elapsed time
            }

            // Breathe out
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"Breathe out... ({i} seconds)\r");
                Thread.Sleep(1000);
                elapsedTime++; // Increment elapsed time
            }
        }

        Console.WriteLine("\nWell done! You have completed the breathing activity.");
    }
}

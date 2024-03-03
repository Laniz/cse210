using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
        if (duration <= 0)
        {
            throw new ArgumentException("Duration must be a positive integer.");
        }
    }

    public void DoBreathing()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting
        
        int elapsedTime = 0;
        DateTime startTime = DateTime.Now;

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

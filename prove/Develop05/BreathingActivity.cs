using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
        // Constructor
    }

    public void DoBreathing()
    {
        Start(); // Start the activity

        // Perform breathing exercises
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine(" ");


        int elapsedTime = 0;
        // DateTime startTime = DateTime.Now;

        // Loop until the elapsed time equals the specified duration
        while (elapsedTime < duration)
        {
            // Breathe in
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"Breathe in... ({i} seconds)\r");
                Thread.Sleep(1000);
                elapsedTime++; // Increment elapsed time
            }

            // Breathe out
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"Breathe out... ({i} seconds)\r");
                Thread.Sleep(1000);
                elapsedTime++; // Increment elapsed time
            }
        }

        Console.WriteLine("\nWell done! You have completed the breathing activity.");


        Finish(); // Finish the activity
    }
}

using System;
using System.Threading;
using System.Diagnostics;

// Base class for mindfulness activities
class MindfulnessActivity 
{
    protected int duration; // Duration of the activity in seconds

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }
    Stopwatch stopwatch = new Stopwatch();

    // Common starting message for all activities
    public void Start()
    {
        
        
        Console.WriteLine($"Starting {GetType().Name} activity...");
        Console.WriteLine("Please prepare to begin.");



        bool toggle = true;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < 5)
        {
            if (toggle)
            {
                Console.Write("+");
            }
            else
            {
                Console.Write("-");
            }

            toggle = !toggle;
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back to overwrite the previous character
            stopwatch.Start();
        }


    }

    // Common finishing message for all activities
    public void Finish()
    {
        stopwatch.Stop();
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Well done! You have completed the {GetType().Name} activity.");
        Console.WriteLine($"Activity duration: {elapsedMilliseconds / 1000} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}

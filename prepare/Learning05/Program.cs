using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public void DoBreathing()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        for (int i = 5; i > 0; i--)
       
        {
            Console.Write($"Breathe in... ({i} seconds)\r");
            Thread.Sleep(1000);
            
        }
        for (int i = 5; i > 0; i--){
            Console.Write($"Breathe out... ({i} seconds) \r");
            Thread.Sleep(1000);
        }

        // }

        // Console.WriteLine("Well done! You have completed the breathing activity.");
    }
    
}

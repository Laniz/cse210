using System;
using System.Threading;

// Reflection activity class
class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = { "Think of a time when you stood up for someone else.",
                                 "Think of a time when you did something really difficult.",
                                 "Think of a time when you helped someone in need.",
                                 "Think of a time when you did something truly selfless." };
    
    private string[] questions = { "Why was this experience meaningful to you?",
                                    "Have you ever done anything like this before?",
                                    "How did you get started?",
                                    "How did you feel when it was complete?",
                                    "What made this time different than other times when you were not as successful?",
                                    "What is your favorite thing about this experience?",
                                    "What could you learn from this experience that applies to other situations?",
                                    "What did you learn about yourself through this experience?",
                                    "How can you keep this experience in mind in the future?" };

    public ReflectionActivity(int duration) : base(duration) { }
    
    // Method to perform the reflection activity
    public void DoReflection()
    {
        Start();
        
        Console.WriteLine($"This activity will help you reflect on times in your life when you have shown strength and resilience. Duration: {duration} seconds.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        // Track the elapsed time
        int elapsedTime = 0;

        // Loop until the duration is reached
        while (elapsedTime < duration)
        {
            // Display a random question
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine(question);

            // Show spinner while pausing
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();

            // Increment elapsed time by the duration of displaying the question
            elapsedTime += 7; // Assuming each question takes 7 seconds
            
            // Sleep for a second before repeating the loop
            Thread.Sleep(1000);
        }

        Finish();
    }
}

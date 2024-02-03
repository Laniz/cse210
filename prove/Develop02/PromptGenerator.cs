using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> Prompts { get; set; }
    private string Response { get; set; }

    public PromptGenerator()
    {
        
        Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the worst part of my day?"
        };
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
        // return("Hello World");
    }
}

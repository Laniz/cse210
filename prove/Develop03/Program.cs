using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."));
        scriptures.Add(new Scripture("Psalm 23:1-3", "The Lord is my shepherd; I shall not want. He makes me lie down in green pastures. He leads me beside still waters. He restores my soul. He leads me in paths of righteousness for his name's sake."));

        foreach (var scripture in scriptures)
        {
            scripture.Display();
            while (!scripture.AllHidden())
            {
                Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    return;

                scripture.HideWords();
                scripture.Display();
            }
        }
    }
}

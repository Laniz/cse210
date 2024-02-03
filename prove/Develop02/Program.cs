using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice;

        do
        {
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("Select one of the following");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    
                    string m =promptGenerator.GetRandomPrompt();
                    Console.WriteLine(m);
                    journal.WriteNewEntry(m);
                    
                    break;
                case "2":
                    Console.WriteLine("Display");
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.WriteLine("Load");
                    journal.LoadJournal();
                    break;
                case "4":
                    Console.WriteLine("Save");
                    journal.SaveJournal();
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

        } while (userChoice != "5");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        
        Player player = new Player(1, "John");

        
        DisplayWelcomeMessage();

        bool isRunning = true;
        while (isRunning)
        {
            
            DisplayMenu();

            
            string input = Console.ReadLine();

            
            switch (input.ToLower())
            {
                case "1":
                    // Add new goal
                    AddNewGoal(player);
                    break;
                case "2":
                    // Record event
                    RecordEvent(player);
                    break;
                case "3":
                    // Display player's goals and score
                    DisplayPlayerInfo(player);
                    break;
                case "4":
                    // Save player's progress
                    SavePlayerProgress(player);
                    break;
                case "5":
                    // Load player's progress
                    LoadPlayerProgress(player);
                    break;
                case "q":
                    // Quit the program
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting the program. Goodbye!");
    }

    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Let's embark on a journey to accomplish our goals.");
        Console.WriteLine();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Add new goal");
        Console.WriteLine("2. Record event (goal completion)");
        Console.WriteLine("3. Display player info");
        Console.WriteLine("4. Save player progress");
        Console.WriteLine("5. Load player progress");
        Console.WriteLine("Q. Quit");
        Console.Write("Select an option: ");
    }

    static void AddNewGoal(Player player)
    {
        // Logic to add a new goal
    }

    static void RecordEvent(Player player)
    {
        // Logic to record an event (goal completion)
    }

    static void DisplayPlayerInfo(Player player)
    {
        // Logic to display player's goals and score
    }

    static void SavePlayerProgress(Player player)
    {
        // Logic to save player's progress
    }

    static void LoadPlayerProgress(Player player)
    {
        // Logic to load player's progress
    }
}

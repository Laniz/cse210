using System;
using System.IO; // For file I/O

class Program
{
    static List<Goal> goals = new List<Goal>();
    static Player player = new Player(1, "John"); 
    // private static int nextGoalId = 1; 
    // private static List<Goal> newGoals = new List<Goal>(); 

    static void Main(string[] args)
    {
        bool quit = false;
        int choice = 0;
        while (!quit)
        {
            DisplayMenu();

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5: 
                        RecordEvent();
                        break;
                    case 6:
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } 
            else 
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Select the type of goal you want to create:");
        Console.WriteLine(" ");
        Console.WriteLine("Here are the Goals you can create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine(" ");
        // ... (Code to display goal types and get user input) ...

        int choice; 
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            
            switch (choice)
            {
                case 1: 
                    Console.WriteLine("Creating a new Simple Goal...");
                    SimpleGoal newSimpleGoal = SimpleGoal.CreateNewSimpleGoal();
                    goals.Add(newSimpleGoal);
                    break;
                case 2: 
                    Console.WriteLine("Creating a new Eternal Goal...");
                    EternalGoal newEternalGoal = EternalGoal.CreateNewEternalGoal();
                    goals.Add(newEternalGoal);
                    break;
                case 3: 
                    Console.WriteLine("Creating a new Checklist Goal...");
                    ChecklistGoal newChecklistGoal = ChecklistGoal.CreateNewChecklistGoal();
                    goals.Add(newChecklistGoal);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } 
    }

    static void ListGoals()
{
    // if (goals.Count == 0) {
    //     Console.WriteLine("You don't have any saved goals yet.");
    //     return;
    // }

    Console.WriteLine("Your Goals:");
    int goalIndex = 1;  

    foreach (Goal goal in goals)
    {
        Console.WriteLine($"{goalIndex}. {goal.Name} ({goal.GetType().Name.Replace("Goal", "")}) : {goal.Description} : {goal.Points} points"); 

        if (goal is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)goal; 
            Console.WriteLine($"  Times before bonus: {checklistGoal.TargetCount}");
            Console.WriteLine($"  Bonus points: {checklistGoal.Bonus}");
        }

        goalIndex++; 
    }
}


   static void SaveGoals()
{
    Console.Write("Enter a filename to save your goals: ");
    string filename = Console.ReadLine();

    // Optional: Add a default extension if not provided 
    if (!filename.EndsWith(".txt"))
    {
        filename += ".txt"; 
    }

    // this saves the file to the user's MyDocuments folder... base folder is C:\Users\yourname\Documents
    string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filename);

    try
    {
        using (StreamWriter writer = new StreamWriter(savePath)) 
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToCustomString());
            }
        }
        Console.WriteLine("Goals saved successfully to " + filename); 
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Error saving goals: Access Denied. Please try a different filename or location.");
    }
    catch (IOException) 
    {
        Console.WriteLine("Error saving goals: ");  
    }
}


    static void LoadGoals()
{
    Console.Write("Enter the filename of your saved goals: ");
    string filename = Console.ReadLine();

    // Optional: Add default extension if not provided 
    if (!filename.EndsWith(".txt"))
    {
        filename += ".txt";
    }

    // Specify a default location to look for saved files
    string loadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filename);

    if (File.Exists(loadPath))
    {
        goals.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(loadPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = Goal.ParseFromCustomFormat(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        } 
        catch (IOException ex)
        {
            Console.WriteLine("Error loading goals: " + ex.Message);
        }
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}

    

    static void RecordEvent()
    {
        // ... (Add code to record an event) ...
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Create New goal");
        Console.WriteLine("2. List Goals (not yet saved)");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals Not yet saved");
        Console.WriteLine("5. Load Goals from saved file");
        Console.WriteLine("6. Record Event");
        Console.WriteLine("7. Quit");
    }
}

using System;

// Base class for all types of goals
public class Goal
{
    // Properties
    public int GoalID { get; set; }
    public string Name { get; set; }
    public bool Completed { get; set; }
    public int TimesCompleted { get; private set; } 

    public string Description { get; set; } 

    public int Points { get; set; }


    // Constructor
    public Goal(int goalID, string name)
    {
        GoalID = goalID;
        Name = name;
        Completed = false;
        TimesCompleted = 0; 
    }

    // Method to mark goal as completed
    public virtual void Complete()
    {
        Completed = true;
        TimesCompleted++; 
        Console.WriteLine($"{Name} completed!");
    }

    // Method to convert Goal object into a custom string format
    public virtual string ToCustomString() 
    {
        string output = $"GoalType: {GetType().Name}\n"; 
        output += $"GoalID: {GoalID}\n";
        output += $"Name: {Name}\n";
        output += $"Description: {Description}\n";
        output += $"Points: {Points}\n";
        output += $"Completed: {Completed}\n";
        output += $"TimesCompleted: {TimesCompleted}\n";
        return output;
    }

    // Method to parse a string (representing a saved goal)
    public static Goal ParseFromCustomFormat(string line)
    {
        string[] parts = line.Split(':');

        if (parts.Length < 2) { 
            return null; 
        }

        string key = parts[0].Trim();
        string value = parts[1].Trim(); 

        if (key == "GoalType")
        {
            switch (value) 
            {
                case "Simple": return SimpleGoal.ParseFromCustomFormat(line); 
                case "Eternal": return EternalGoal.ParseFromCustomFormat(line);
                case "Checklist": return ChecklistGoal.ParseFromCustomFormat(line);
                default: return null;  
            }
        }
        return null; 
    }

    // Helper method to initialize properties from save data
    public void InitializeFromSaveData(bool completed, int timesCompleted) 
    {
        Completed = completed;
        TimesCompleted = timesCompleted;
    }
}

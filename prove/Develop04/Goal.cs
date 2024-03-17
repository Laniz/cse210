using System;

// Base class for all types of goals
public class Goal
{
    // Properties
    public int GoalID { get; set; }
    public string Name { get; set; }
    public bool Completed { get; set; }

    // Constructor
    public Goal(int goalID, string name)
    {
        GoalID = goalID;
        Name = name;
        Completed = false;
    }

    // Method to mark goal as completed
    public virtual void Complete()
    {
        Completed = true;
        Console.WriteLine($"{Name} completed!");
    }
}

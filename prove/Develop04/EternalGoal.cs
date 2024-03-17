using System;

// Derived class for eternal goals
public class EternalGoal : Goal
{
    // Properties
    public int Value { get; set; }

    // Constructor
    public EternalGoal(int goalID, string name, int value) : base(goalID, name)
    {
        Value = value;
    }

    // Override Complete method
    public override void Complete()
    {
        base.Complete();
        Console.WriteLine($"Gained {Value} points!");
    }
}

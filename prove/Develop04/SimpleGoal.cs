using System;

// Derived class for simple goals
public class SimpleGoal : Goal
{
    // Properties
    public int Value { get; set; }

    // Constructor
    public SimpleGoal(int goalID, string name, int value) : base(goalID, name)
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

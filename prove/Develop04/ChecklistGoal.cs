using System;

// Derived class for checklist goals
public class ChecklistGoal : Goal
{
    // Properties
    public int Value { get; set; }
    public int Target { get; set; }
    public int CompletedCount { get; set; }

    // Constructor
    public ChecklistGoal(int goalID, string name, int value, int target) : base(goalID, name)
    {
        Value = value;
        Target = target;
        CompletedCount = 0;
    }

    // Override Complete method
    public override void Complete()
    {
        base.Complete();
        CompletedCount++;
        Console.WriteLine($"Gained {Value} points!");

        if (CompletedCount == Target)
        {
            Console.WriteLine($"Bonus: Gained additional {Value * 5} points for completing {Target} times!");
        }
    }
}

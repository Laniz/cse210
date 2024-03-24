
class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;

    public ChecklistGoal(string name, int value, int requiredTimes)
    {
        Name = name;
        Value = value;
        this.requiredTimes = requiredTimes;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        Console.WriteLine($"Goal '{Name}' completed ({timesCompleted}/{requiredTimes})! You gained {Value} points.");
        if (IsComplete())
        {
            Console.WriteLine($"Bonus: You achieved the goal {requiredTimes} times! Bonus: {Value * 2} points.");
        }
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[{timesCompleted}/{requiredTimes}] {Name}");
    }

    public override bool IsComplete()
    {
        return timesCompleted >= requiredTimes;
    }
}

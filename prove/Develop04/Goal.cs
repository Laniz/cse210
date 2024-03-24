
class Goal
{
    public string Name { get; set; }
    public int Value { get; protected set; }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! You gained {Value} points.");
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"[{(IsComplete() ? "X" : " ")}] {Name}");
    }

    public virtual bool IsComplete()
    {
        return false;
    }
}

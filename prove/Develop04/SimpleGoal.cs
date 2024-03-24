
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public override bool IsComplete()
    {
        return true;
    }
}

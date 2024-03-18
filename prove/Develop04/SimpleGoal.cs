using System;

// Simple Goal class inheriting from Goal
class SimpleGoal : Goal
{
    // public string Description { get; set; }
    // public int Points { get; set; }

   public SimpleGoal(int id, string name, string description, int points) : base(id, name)
{
    Description = description;
    Points = points;
}


    public override void Complete()
    {
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    }

    public static SimpleGoal CreateNewSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for points.");
            Console.Write("What is the amount of points associated with this goal? ");
        }

        return new SimpleGoal(1, name, description, points);
    }

    // public static SimpleGoal ParseFromCustomFormat(string line)
    // {
    //     string[] parts = line.Split(':');
    //     if (parts.Length < 7) { return null; } 

    //     int goalId = int.Parse(parts[1].Trim());
    //     string name = parts[2].Trim();
    //     string description = parts[3].Trim();
    //     int points = int.Parse(parts[4].Trim());
    //     bool completed = bool.Parse(parts[5].Trim()); 
    //     int timesCompleted = int.Parse(parts[6].Trim());

    //     SimpleGoal goal = new SimpleGoal(goalId, name, description, points);
    //     goal.InitializeFromSaveData(completed, timesCompleted);
    //     return goal;
    // }

    public override string ToCustomString() 
{
    string output = $"GoalType: SimpleGoal\n"; 
    output += $"GoalID: {GoalID}\n";
    output += $"Name: {Name}\n";
    output += $"Description: {Description}\n";
    output += $"Points: {Points}\n";
    output += $"Completed: {Completed}\n";
    output += $"TimesCompleted: {TimesCompleted}\n";
    return output;
}
}

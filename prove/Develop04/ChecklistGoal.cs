using System;

class ChecklistGoal : Goal
{
    public string Description { get; set; }
    public int Points { get; set; }
    public int TargetCount { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(int id, string name, string description, int points, int targetCount, int bonus) : base(id, name)
    {
        Description = description;
        Points = points;
        TargetCount = targetCount;
        Bonus = bonus;
    }

    public override void Complete()
    {
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");

        // Check if the goal was completed enough times to earn a bonus
        if (TimesCompleted >= TargetCount)
        {
            Console.WriteLine($"Congratulations! You earned a bonus of {Bonus} points.");
        }
    }

    public static ChecklistGoal CreateNewChecklistGoal()
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

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int targetCount;
        while (!int.TryParse(Console.ReadLine(), out targetCount) || targetCount <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the target count.");
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        }

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus;
        while (!int.TryParse(Console.ReadLine(), out bonus) || bonus <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the bonus.");
            Console.Write("What is the bonus for accomplishing it that many times? ");
        }

        return new ChecklistGoal(1, name, description, points, targetCount, bonus);
    }

    public static ChecklistGoal ParseFromCustomFormat(string line)
    {
        string[] parts = line.Split(':');
        if (parts.Length < 7) { return null; } // Handle invalid format

        int goalId = int.Parse(parts[1].Trim());
        string name = parts[2].Trim();
        string description = parts[3].Trim();
        int points = int.Parse(parts[4].Trim());
        int targetCount = int.Parse(parts[5].Trim());  
        int bonus = int.Parse(parts[6].Trim());

        return new ChecklistGoal(goalId, name, description, points, targetCount, bonus);
    }

    public override string ToCustomString() 
{
    string output = $"GoalType: ChecklistGoal\n"; 
    output += $"GoalID: {GoalID}\n";
    output += $"Name: {Name}\n";
    output += $"Description: {Description}\n";
    output += $"Points: {Points}\n";
    output += $"TargetCount: {TargetCount}\n";
    output += $"Bonus: {Bonus}\n";
    return output;
}
}

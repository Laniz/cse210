// Eternal Goal class
public class EternalGoal : Goal  
{


    // Constructor
    public EternalGoal(string name, string description, int points) : base(0, name)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    // Method to create a new EternalGoal
    public static EternalGoal CreateNewEternalGoal()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a short description of the goal:");
        string description = Console.ReadLine();

        int points;
        Console.WriteLine("Enter the points associated with this goal:");
        while (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for points:");
        }

        return new EternalGoal(name, description, points);
    }

    // Method to parse from custom format 
    // public static EternalGoal ParseFromCustomFormat(string line)
    // {
    //     string[] parts = line.Split(':');

    //     if (parts.Length < 5) { 
    //         return null; // Handle invalid format
    //     }

    //     string name = parts[1].Trim();
    //     string description = parts[2].Trim();
    //     int points = int.Parse(parts[3].Trim());

    //     return new EternalGoal(name, description, points); 
    // }

    public override string ToCustomString() 
{
    string output = $"GoalType: EternalGoal\n"; 
    output += $"GoalID: {GoalID}\n"; // 
    output += $"Name: {Name}\n";
    output += $"Description: {Description}\n";
    output += $"Points: {Points}\n";
    return output;
}
}

using System.IO;
class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayStatus();
        }
    }

    
    public void SaveGoals()
    {
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.Name},{goal.Value},{goal.IsComplete()},{goal.GetType()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter filename:");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // string[] parts = line.Split(',');
            // string name = parts[0];
            // int value = int.Parse(parts[1]);
            // Goal.isComplete = bool.Parse(parts[2]);
            // Goal.goalType = parts[3];
            // Goal goal = new Goal(name, value);
            // goals.Add(goal);
            string[] parts = line.Split(',');
            string name = parts[0];
            int value = int.Parse(parts[1]);
            bool isComplete = bool.Parse(parts[2]);
            string goalType = parts[3];

            Goal goal;
            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal(name, value);
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(name, value);
            }
            else if (goalType == "ChecklistGoal")
            {
                int requiredTimes = int.Parse(parts[4]);
                goal = new ChecklistGoal(name, value, requiredTimes);
            }

            else
            {
                Console.WriteLine("Invalid goal type.");
                continue;
            }

            if (isComplete)
            {
                typeof(Goal).GetMethod("IsComplete").Invoke(goal, null);
            }

            goals.Add(goal);
        }
    }
}

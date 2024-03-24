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
            string goalLine;
            if (goal is ChecklistGoal checklistGoal)
            {
                goalLine = $"{goal.Name},{goal.Value},{goal.IsComplete()},{goal.GetType()},{checklistGoal.RequiredTimes},{checklistGoal.TimesCompleted}";
            }
            else
            {
                goalLine = $"{goal.Name},{goal.Value},{goal.IsComplete()},{goal.GetType()},-1,-1"; // Placeholder for timesCompleted and requiredTimes
            }
            outputFile.WriteLine(goalLine);
        }
    }
    }

   public void LoadGoals()
{
    Console.WriteLine("Enter filename:");
    string filename = Console.ReadLine();
    string[] lines = File.ReadAllLines(filename);

    for (int i = 0; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(',');

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
            int timesCompleted = int.Parse(parts[5]);
            goal = new ChecklistGoal(name, value, requiredTimes);
            ((ChecklistGoal)goal).TimesCompleted = timesCompleted;
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

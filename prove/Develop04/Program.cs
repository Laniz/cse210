class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter goal type (1. Simple, 2. Eternal, 3. Checklist):");
                    string goalType = Console.ReadLine();

                    Console.WriteLine("Enter goal name:");
                    string goalName = Console.ReadLine();

                    Console.WriteLine("Enter goal value:");
                    int goalValue = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        goalManager.AddGoal(new SimpleGoal(goalName, goalValue));
                    }
                    else if (goalType == "2")
                    {
                        goalManager.AddGoal(new EternalGoal(goalName, goalValue));
                    }
                    else if (goalType == "3")
                    {
                        Console.WriteLine("Enter required times for the checklist goal:");
                        int requiredTimes = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new ChecklistGoal(goalName, goalValue, requiredTimes));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter the index of the goal to record an event:");
                    int eventIndex;
                    if (int.TryParse(Console.ReadLine(), out eventIndex))
                    {
                        goalManager.RecordEvent(eventIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid index.");
                    }
                    break;

                case "3":
                    goalManager.DisplayGoals();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
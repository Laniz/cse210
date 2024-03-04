using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Display menu options
        Console.WriteLine(" ");
        Console.WriteLine("Select an activity:");
        Console.WriteLine(" ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine(" ");

        // Get user input for activity selection
        int choice = GetMenuChoice();

        // Execute the selected activity
        switch (choice)
        {
            case 1:
                DoBreathing();
                break;
            case 2:
                DoReflectionActivity();
                break;
            case 3:
                DoListingActivity();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number from the menu.");
                break;
        }
    }

    static int GetMenuChoice()
    {
        int choice;
        while (true)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
                return choice;
            else
                Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void DoBreathing()
{
    int duration = GetDuration();
    BreathingActivity breathingActivity = new BreathingActivity(duration);
    breathingActivity.DoBreathing();
}

    static void DoReflectionActivity()
    {
        int duration = GetDuration();
        ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
        reflectionActivity.DoReflection();
    }

    static void DoListingActivity()
    {
        int duration = GetDuration();
        ListingActivity listingActivity = new ListingActivity(duration);
        listingActivity.DoListing();
    }

    static int GetDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter the duration of the activity (in seconds): ");
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
                return duration;
            else
                Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}

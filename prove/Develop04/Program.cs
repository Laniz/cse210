using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample usage
        Player player1 = new Player(1, "John");
        Goal goal1 = new SimpleGoal(1, "Run a marathon", 1000);
        Goal goal2 = new EternalGoal(2, "Read scriptures", 100);
        Goal goal3 = new ChecklistGoal(3, "Attend temple", 50, 10);

        player1.DisplayScore();

        goal1.Complete();
        player1.UpdateScore(1000);

        goal2.Complete();
        player1.UpdateScore(100);

        goal3.Complete();
        player1.UpdateScore(50);

        player1.DisplayScore();
    }
}

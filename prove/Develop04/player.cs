using System;

// Class to track player's progress
public class Player
{
    // Properties
    public int PlayerID { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }

    // Constructor
    public Player(int playerID, string name)
    {
        PlayerID = playerID;
        Name = name;
        Score = 0;
    }

    // Method to update player's score
    public void UpdateScore(int points)
    {
        Score += points;
    }

    // Method to display player's score
    public void DisplayScore()
    {
        Console.WriteLine($"Player {Name}'s score: {Score}");
    }
}

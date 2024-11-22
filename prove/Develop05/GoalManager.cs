using System.ComponentModel;
using System.IO;

class GoalManager 
{
    // Attribute to track the total points earned by the user    
    private int _totalPoints;

    // Methods
    // Returns the toal points earned
    public int GetTotalPoints() 
    {
        return _totalPoints;
    }

    // Add the specified number of points tothe total points
    public void AddPoints(int points) 
    {
        _totalPoints += points;
    }

    // Saves the total points and goals to a specified file
    public void Save(List<Goal> goals, string fileName) 
    {
        // Using StreamWriter to write data to the file
        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            // Save total points as the first line
            outputFile.WriteLine(_totalPoints);

            // Save each goal in a serialized format (defined by GetSaveFormat)
            foreach (Goal goal in goals) 
            {
                outputFile.WriteLine(goal.GetSaveFormat());
            }
        }

        // Reset total points to zero after saving
        _totalPoints = 0;
    }

    // Loads goals and total points from a specified file
    public List<Goal> Load(string fileName) 
    {
        // Read all lines from the file
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // Initialize a new list to store the loaded goals
        List<Goal> goals = new();

        // Process each line in the file
        foreach (string line in lines) 
        {
            // Split the line into parts based on the delimiter ":"
            string[] parts = line.Split(":");

            // Check the type of goal and reconstruct it from the file date
            if (parts[0] == "SimpleGoal") 
            {
                // Create a Simple Goal with parse data
                goals.Add(new SimpleGoal(
                    int.Parse(parts[3]),   // Points
                    parts[1],              // Name
                    parts[2],              // Description
                    bool.Parse(parts[4])   // Completion Status
                ));
            }
            else if (parts[0] == "EternalGoal")
             {
                // Create an EternalGoal with parsed data
                goals.Add(new EternalGoal(
                    int.Parse(parts[3]),    // Points
                    parts[1],               // Name
                    parts[2]                // Description
                ));
            }
            else if (parts[0] == "ChecklistGoal") 
            {
                // Create a ChecklistGoal with parsed data
                goals.Add(new ChecklistGoal(
                    int.Parse(parts[5]),    // Completion requirement
                    int.Parse(parts[4]),    // Bonus points
                    int.Parse(parts[3]),    // Points
                    parts[1],               // Name
                    parts[2],               // Description
                    int.Parse(parts[6])     // Times completed
                ));
            }
            else 
            {
                // If the line doesn't describe a goal, it's the total points
                _totalPoints = int.Parse(parts[0]);
            }
        }

        // Return the list of loaded goals
        return goals;
    }
}
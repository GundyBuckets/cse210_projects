using System.IO;

class GoalManager {
    private int _totalPoints;

    public void DisplayGoals(List<Goal> goals) {
        foreach (Goal goal in goals) {
            
        }
    }
    public void Save(List<Goal> goals, string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in goals) {
                outputFile.WriteLine(goal.GetSaveFormat());
            }
        }
    }

    public List<Goal> Load(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Goal> goals = new();
        foreach (string line in lines) {
            string[] parts = line.Split(":");

            if (parts[0] == "SimpleGoal") {
                goals.Add(new SimpleGoal(int.Parse(parts[3]), parts[1], parts[2], bool.Parse(parts[4])));
            }
            if (parts[0] == "EternalGoal") {
                goals.Add(new EternalGoal(int.Parse(parts[3]), parts[1], parts[2]));
            }
            if (parts[0] == "ChecklistGoal") {
                goals.Add(new ChecklistGoal(int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[3]), parts[1], parts[2], int.Parse(parts[6])));
            }
            else {
                _totalPoints = int.Parse(parts[0]);
            }
        }

        return goals;
    }
}
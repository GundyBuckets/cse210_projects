using System.Runtime.InteropServices;
// A specific type of goal where multiple tasks must be completed before receiving a bonus
class ChecklistGoal : Goal
{
    // Field to store the number of times the goal must be completed to earn the bonus
    private int _toComplete;

    // Field to store the number of times the goal has been completed
    private int _timesCompleted;

    // Field to store the bonus points for completing the goal a specific number of times
    private int _bonus;

    // Constructor to initialize a checklist goal with points, name, description, required completions, and bonus
    public ChecklistGoal(int to, int b, int p, string n, string d) : base(p, n, d, "ChecklistGoal")
    {
        _toComplete = to;
        _timesCompleted = 0; // Initially, the goal is not completed
        _bonus = b;
    }

    // Overloaded constructor to initialize with an additional completed count
    public ChecklistGoal(int to, int b, int p, string n, string d, int completed) : base(p, n, d, "ChecklistGoal")
    {
        _toComplete = to;
        _timesCompleted = completed; // Set the initial number of completions
        _bonus = b;
    }

    // Overrides GetDisplayFormat to show the completion status and how many times the goal has been completed
    public override string GetDisplayFormat()
    {
        if (IsComplete()) {
            // If the goal is complete, display the number of completions with a checked box
            return $"[X] {base.GetDisplayFormat()} -- Currently completed: {_timesCompleted}/{_toComplete}";
        }
        else {
            // If the goal is incomplete, display the number of completions with an empty box
            return $"[ ] {base.GetDisplayFormat()} -- Currently completed: {_timesCompleted}/{_toComplete}";
        }
    }

    // Overrides GetSaveFormat to include additional properties (bonus, times completed, total completions needed)
    public override string GetSaveFormat()
    {
        // Format for saving: type:name:description:points:bonus:toComplete:timesCompleted
        return base.GetSaveFormat() + $":{_bonus}:{_toComplete}:{_timesCompleted}";
    }

    // Overrides RecordEvent to increment the times completed and award points when the goal is completed
    public override int RecordEvent()
    {
        _timesCompleted++;  // Increment the completion count
        if (!IsComplete()) {
            // If the goal is not complete, return the points for this event
            return base.RecordEvent();
        }
        else {
            // If the goal is complete, return the bonus plus the points for this event
            return _bonus + base.RecordEvent();
        }
    }

    // Overrides IsComplete to check if the goal has been completed the required number of times
    public override bool IsComplete()
    {
        // If the number of completions equals the required completions, the goal is complete
        if (_timesCompleted == _toComplete) {
            return true;
        }
        else {
            return false;
        }
    }
}

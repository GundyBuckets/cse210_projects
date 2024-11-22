// A specific type of goal that can be marked as complete or incomplete
class SimpleGoal : Goal
{
    // Field to store whether the goal is complete or not
    private bool _complete;

    // Constructor to initialize the goal with points, name, description, and default incomplete status
    public SimpleGoal(int p, string n, string d) : base(p, n, d, "SimpleGoal")
    {
        _complete = false;
    }

    // Overloaded constructor to initialize the goal with points, name, description, and completion status
    public SimpleGoal(int p, string n, string d, bool c) : base(p, n, d, "SimpleGoal")
    {
        _complete = c;
    }

    // Overrides GetDisplayFormat to show the completion status (checkbox style)
    public override string GetDisplayFormat()
    {
        if (_complete)
        {
            // If complete, display with checked box
            return $"[X] {base.GetDisplayFormat()}";
        }
        else
        {
            // If incomplete, display with empty box
            return $"[ ] {base.GetDisplayFormat()}";
        }
    }

    // Overrides GetSaveFormat to include the completion status when saving the goal
    public override string GetSaveFormat()
    {
        return base.GetSaveFormat() + $":{_complete}";
    }

    // Overrides RecordEvent to mark the goal as complete when an event is recorded
    public override int RecordEvent()
    {
        _complete = true;  // Mark the goal as complete
        return base.RecordEvent(); // Return the points associated with the goal
    }

    // Overrides IsComplete to check if the goal is complete
    public override bool IsComplete()
    {
        return _complete;
    }
}

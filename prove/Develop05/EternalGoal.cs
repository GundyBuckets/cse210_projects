// A specific type of goal that does not have a completion state
class EternalGoal : Goal
{
    // Constructor for the EternalGoal class
    // Passes points, name, description, and type to the base Goal constructor
    public EternalGoal(int p, string n, string d) : base(p, n, d, "EternalGoal") {}

    // Overrides the GetDisplayFormat method to provide a unique display format for EternalGoals
    public override string GetDisplayFormat()
    {
        // Displays the goal with a checkbox-like indicator, always unchecked
        return $"[ ] {base.GetDisplayFormat()}";
    }
}

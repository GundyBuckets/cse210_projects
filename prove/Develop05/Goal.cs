using System.ComponentModel;

// Base class representing a general goal
class Goal
{
    // Fields to store the goal's points, name, description, and type
    private int _points;
    private string _name;
    private string _description;
    private string _type;

    // Constructor to initialize a goal with points, name, description, and type
    public Goal(int p, string n, string d, string t)
    {
        _points = p;
        _name = n;
        _description = d;
        _type = t;
    }

    // Method to generate a save format for the goal
    // This format is used to serialize the goal to a file
    public virtual string GetSaveFormat()
    {
        return $"{_type}:{_name}:{_description}:{_points}";
    }

    // Method to record an event (e.g., completing the goal) and return points earned
    // By default, it returns the goal's points
    public virtual int RecordEvent()
    {
        return _points;
    }

    // Method to generate a user-friendly display format for the goal
    public virtual string GetDisplayFormat()
    {
        return $"{_name}: ({_description})";
    }

    // Method to check if the goal is complete
    // Always returns false by default (override in derived classes for specific behavior)
    public virtual bool IsComplete()
    {
        return false;
    }

    // Getter for the goal's points
    public virtual int GetPoints()
    {
        return _points;
    }

    // Getter for the goal's name
    public string GetName()
    {
        return _name;
    }
}

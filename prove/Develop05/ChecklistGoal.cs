using System.Runtime.InteropServices;

class ChecklistGoal : Goal {
    private int _toComplete;
    private int _timesCompleted;
    private int _bonus;
    
    public ChecklistGoal(int to, int b, int p, string n, string d) : base (p, n, d, "ChecklistGoal") {
        _toComplete = to;
        _timesCompleted = 0;
        _bonus = b;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    public override bool IsComplete()
    {
        if (_timesCompleted == _toComplete) {
            return true;
        }
        else {
            return false;
        }
    }
}
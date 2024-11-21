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

    public ChecklistGoal(int to, int b, int p, string n, string d, int completed) : base (p, n, d, "ChecklistGoal") {
        _toComplete = to;
        _timesCompleted = completed;
        _bonus = b;
    }

    public override string GetDisplayFormat() {
        if (IsComplete()) {
            return $"[X] {base.GetDisplayFormat()} -- Currently completed: {_timesCompleted}/{_toComplete}";
        }
        else {
            return $"[ ] {base.GetDisplayFormat()} -- Currently completed: {_timesCompleted}/{_toComplete}";
        }
    }

    public override string GetSaveFormat()
    {
        // Will return
        // type:name:description:points:bonus:toComplete:timesCompleted
        return base.GetSaveFormat() + $":{_bonus}:{_toComplete}:{_timesCompleted}";
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
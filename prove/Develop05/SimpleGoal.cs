class SimpleGoal : Goal {
    private bool _complete;

    public SimpleGoal(int p, string n, string d) : base(p, n, d, "SimpleGoal") {
        _complete = false;
    }

    public SimpleGoal(int p, string n, string d, bool c) : base(p, n, d, "SimpleGoal") {
        _complete = c;
    }

    public override string GetDisplayFormat()
    {
        if (_complete) {
            return $"[X] {base.GetDisplayFormat()}";
        }
        else {
            return $"[ ] {base.GetDisplayFormat()}";
        }
    }

    public override string GetSaveFormat()
    {
        return base.GetSaveFormat() + $":{_complete}";
    }

    public override int RecordEvent() {
        _complete = true;
        return base.RecordEvent();
    }

    public override bool IsComplete() {
        return _complete;
    }
}
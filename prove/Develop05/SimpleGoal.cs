class SimpleGoal : Goal {
    private bool _complete;

    public SimpleGoal(int p, string n, string d) : base(p, n, d, "SimpleGoal") {
        _complete = false;
    }

    public SimpleGoal(int p, string n, string d, bool c) : base(p, n, d, "SimpleGoal") {
        _complete = c;
    }

    public override string GetSaveFormat()
    {
        return base.GetSaveFormat() + $":{_complete}";
    }

    public override void RecordEvent() {
        _complete = true;
    }

    public override bool IsComplete() {
        return _complete;
    }
}
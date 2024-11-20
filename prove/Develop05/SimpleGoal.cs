class SimpleGoal : Goal {
    private bool _complete;

    public SimpleGoal(int p, string n, string d) : base(p, n, d, "SimpleGoal") {
        _complete = false;
    }

    public override void RecordEvent() {
        _complete = true;
    }

    public override bool IsComplete() {
        return _complete;
    }
}
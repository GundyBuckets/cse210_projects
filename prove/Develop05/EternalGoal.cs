class EternalGoal : Goal {
    public EternalGoal(int p, string n, string d) : base(p, n, d, "EternalGoal") {}

    public override string GetDisplayFormat() {
        return $"[ ] {base.GetDisplayFormat()}";
    }
}
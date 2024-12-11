class Running : Activity {
    // Attributes
    private double _distance;

    // Constructor
    public Running(int l, double d) : base(l) {
        _distance = d;
    }

    // Methods
    public override double GetDistance() {
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed() {
        return Math.Round((_distance / _length) * 60, 2);
    }

    public override double GetPace() {
        return Math.Round(_length / _distance, 2);
    }

    public override string GetSummary() {
        return base.GetSummary() + $" Running ({_length} min): Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
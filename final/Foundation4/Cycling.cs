class Cycling : Activity {
    // Attributes
    private double _speed;

    // Constructor
    public Cycling(int l, double s) : base(l) {
        _speed = s;
    }

    // Methods
    public override double GetDistance() {
        return Math.Round(_speed * (_length / 60), 2);
    }

    public override double GetSpeed() {
        return Math.Round(_speed, 2);
    }

    public override double GetPace() {
        return Math.Round(_length / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" Cycling ({_length} min): Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
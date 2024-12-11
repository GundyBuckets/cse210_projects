class Swimming : Activity {
    // Attribute
    private int _laps;

    // Constructor
    public Swimming(int laps, int l) : base(l) {
        _laps = laps;
    }

    // Methods
    public override double GetDistance() {
        double distance = (_laps * 50) * 0.00062137;
        return Math.Round(distance, 2);
    }

    public override double GetSpeed() {
        return Math.Round((GetDistance() / _length) * 60, 2);
    }

    public override double GetPace() {
        return  Math.Round(_length / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" Swimming ({_length} min): Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
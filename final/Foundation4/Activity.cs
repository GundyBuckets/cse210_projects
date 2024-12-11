class Activity {
    // Attributes
    private DateTime _date;
    protected float _length;

    // Constructor
    public Activity(int l) {
        _date = DateTime.Now;
        _length = l;
    }

    // Methods
    public virtual double GetDistance() {
        return 1.0;
    }
    public virtual double GetSpeed() {
        return 1.0;
    }
    public virtual double GetPace() {
        return 1.0;
    }
    public virtual string GetSummary() {
        return $"{_date.Date}";
    }
}
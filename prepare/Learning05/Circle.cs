class Circle:Shape {
    // Attribute
    private double _radius;

    // Constructor
    public Circle(string c, double r) : base(c) {
        _radius = r;
    }

    // Method
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
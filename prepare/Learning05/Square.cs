class Square:Shape {
    // Attributes
    private double _side;

    // Constructor
    public Square(string c, double s) : base(c) {
        _side = s;
    }

    // Method

    public override double GetArea()
    {
        return _side * _side;
    }
}
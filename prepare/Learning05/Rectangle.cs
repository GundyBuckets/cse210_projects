class Rectangle:Shape {
    // Attributes
    private double _length;
    private double _width;

    // Constructor
    public Rectangle(string c, double l, double w) : base (c) {
        _length = l;
        _width = w;
    }

    public override double GetArea() {
        return _length * _width;
    }
}
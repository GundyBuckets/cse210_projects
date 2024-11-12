class Shape {
    // Attributes
    private string _color;

    // Constructor
    public Shape(string c) {
        _color = c;
    }

    // Methods
    public string GetColor() {
        return _color;
    }
    public void SetColor(string c) {
        _color = c;
    }
    public virtual double GetArea() {
        return 1.0;
    }
}
class Product {
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string n, string i, double p, int q) {
        _name = n;
        _productId = i;
        _price = p;
        _quantity = q;
    }

    public string GetProductId() {
        return _productId;
    }

    public string GetName() {
        return _name;
    }

    public double ComputePrice() {
        return _price * _quantity;
    }
}
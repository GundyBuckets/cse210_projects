class Order {
    private Customer _customer;
    private List<Product> _products;

    public Order() {
        _products = [];
    }

    public string GetPackingLabel() {
        string result = "";
        foreach (Product product in _products) {
            result += $"Product Id: {product.GetProductId()} Name: {product.GetName()}\n";
        }
        return result;
    }

    public string GetShippingLabel() {
        return _customer.GetAddress();
    }

    public double CalculateTotalCost() {
        double result = 0;
        foreach (Product product in _products) {
            result += product.ComputePrice();
        }
        if (_customer.IsFromUSA()) {
            result += 5;
        }
        else {
            result += 35;
        }
        return result;
    }

    public void SetCustomer(Customer c) {
        _customer = c;
    }

    public void AddProduct(Product p) {
        _products.Add(p);
    }
}
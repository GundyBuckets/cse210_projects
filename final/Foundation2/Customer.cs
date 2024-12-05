class Customer {
    private string _name;
    private Address _address;

    public Customer(string n, Address a) {
        _name = n;
        _address = a;
    }

    public string GetName() {
        return _name;
    }

    public string GetAddress() {
        return _address.GetFormattedAddress();
    }

    public bool IsFromUSA() {
        if (_address.GetCountry() == "USA"){
            return true;
        }
        else {
            return false;
        }
    }
}
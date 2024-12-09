class Address {
    private string _streetAddress;
    private string _city;
    private string _state;

    public Address(string street, string city, string state) {
        _streetAddress = street;
        _city = city;
        _state = state;
    }

    public string GetFormattedAddress() {
        return $"{_streetAddress} {_city}, {_state}";
    }
}
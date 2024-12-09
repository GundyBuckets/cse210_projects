class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address) {
        _weather = weather;
    }

    public override string ShortDetails()
    {
        return "Type: Outdoor\n" + base.ShortDetails();
    }

    public string FullDetails() {
        return StandardDetails() +
            $"Weather: {_weather}";
    }
}
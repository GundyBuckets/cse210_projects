class Reception : Event {
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address) {
        _email = email;
    }

    public override string ShortDetails()
    {
        return "Type: Reception\n" + base.ShortDetails();
    }

    public string FullDetails() {
        return StandardDetails() + 
               $"\nPlease RSVP to {_email}";
    }
}
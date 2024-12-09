class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, Address add, string speaker, int cap) : base(title, desc, date, time, add) {
        _speaker = speaker;
        _capacity = cap;
    }

    public string FullDetails() {
        return StandardDetails() +
               $"Speaker: {_speaker}" +
               $"Maximum capacity: {_capacity}";
    }

    public override string ShortDetails() {
        return $"Type: Lecture\n" + base.ShortDetails();
    }
}
public class WritingAssignment : Assignment {
    // Attributes
    string _title;

    // Constructors
    public WritingAssignment(string title, string name, string topic) : base(name, topic) {
        _title = title;
    }

    // Methods
    public string GetWritingInformation() {
        return $"{_title} by {_studentName}";
    }
}
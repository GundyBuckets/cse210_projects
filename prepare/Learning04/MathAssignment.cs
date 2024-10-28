class MathAssignment : Assignment {
    // Attributes
    string _textbookSection;
    string _problems;

    // Constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic) {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{_textbookSection} {_problems}";
    }
}
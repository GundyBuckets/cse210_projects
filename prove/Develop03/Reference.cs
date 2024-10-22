class Reference {
    // Attributes
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    // Constructors
    public Reference(string book, string chapter, string verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, string chapter, string verse, string endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Methods
    public string GetReference() {
        string reference = $"{_book} {_chapter}:{_verse}";
        if (_endVerse != null) {
            reference += $"-{_endVerse}";
        }
        return reference;
    }
}
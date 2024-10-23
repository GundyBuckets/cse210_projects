class Reference {
    // Attributes
    private string _reference;

    // Constructors
    public Reference(string book, string chapter, string verse) {
        _reference = $"{book} {chapter}:{verse}";
    }
    public Reference(string book, string chapter, string verse, string endVerse) {
        _reference = $"{book} {chapter}:{verse}-{endVerse}";
    }

    // Methods
    public string GetReference() {
        return _reference;
    }
}
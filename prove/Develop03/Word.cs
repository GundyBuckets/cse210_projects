class Word {
    // Attributes
    private string _word;
    private bool _isHidden;
    private string _hiddenWord;

    // Constructor
    public Word(string word) {
        _word = word;
        _isHidden = false;
        
        // Makes _hiddenWord dashes equal to the length of the word
        _hiddenWord = new string('_', _word.Length);
    }

    // Methods
    public string GetWord() {
        if (_isHidden == false) {
            return _word;
        } else {
            return _hiddenWord;
        }
    }
    public bool HideWord() {
        // Checks if the word is already hidden and returns a bool to say if it actually did anything        
        if (_isHidden == false) {
            _isHidden = true;
            return true;
        } else {
            return false;
        }
    }
}
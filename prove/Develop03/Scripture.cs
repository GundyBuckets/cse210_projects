using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Scripture {
    // Attributes
    private Reference _scriptureReference;
    private List<Word> _words = new();
    private int _hiddenWords;
    
    // Constructors
    public Scripture(Reference reference, string scripture) {
        _scriptureReference = reference;
        string[] words = scripture.Split(' ');
        _hiddenWords = 0;

        foreach (string word in words) {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // Methods
    public void Display() {
        // Display Reference first
        Console.WriteLine(_scriptureReference.GetReference());

        // Display the scripture
        foreach (Word wordObject in _words) {
            string word = wordObject.GetWord();
            Console.Write($"{word} ");
        }
        Console.WriteLine($"\n{_words.Count - _hiddenWords} words remaining ({_hiddenWords} words hidden)");
    }

    public void HideWords(int wordsToHide) {
        if (_hiddenWords < _words.Count) {
            if ((_words.Count - _hiddenWords) <= wordsToHide) {
                wordsToHide = _words.Count - _hiddenWords;
            }       
            int count = 0;

            while (count < wordsToHide) {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count);
                Word randomWord = _words[randomIndex];
                if (randomWord.HideWord() == true) {
                    count += 1;
                    _hiddenWords += 1;
                }
            }
        }
    }
}
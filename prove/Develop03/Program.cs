using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Word class
        /* Word testWord = new Word("Behold");
        Console.WriteLine(testWord.GetWord());
        testWord.HideWord();
        Console.WriteLine(testWord.GetWord()); */

        // Testing the Reference class
        /* Reference firstReference = new Reference("D&C", "138", "4");
        Console.WriteLine($"This is the first reference {firstReference.GetReference()}");
        Reference secondReference = new Reference("D&C", "138", "4", "6");
        Console.WriteLine($"This is the second reference {secondReference.GetReference()}"); */

        // Testing the Scripture Class while attribute are public
        /* Reference newReference = new Reference ("D&C", "18", "10");
        string text = "Remember the worth of souls is great in the sight of God";
        Scripture testScripture = new Scripture(newReference, text);

        Console.WriteLine(testScripture._scriptureReference.GetReference());
        foreach (Word wordObject in testScripture._words) {
            string word = wordObject.GetWord();
            Console.WriteLine(word);
        } */

        // Testing Scripture Display
        /* Reference newReference = new Reference ("D&C", "18", "10");
        string text = "Remember the worth of souls is great in the sight of God";
        Scripture testScripture = new Scripture(newReference, text);
        testScripture.Display();
        testScripture.HideWords(3);
        testScripture.Display(); */

        // Main Program

        // Making the scripture object with Mosiah 3:19
        Reference reference = new Reference ("Mosiah", "3", "19");
        string scriptureString = "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father";
        Scripture scriptureObject = new Scripture(reference, scriptureString);

        // Welcom to the program
        Console.WriteLine("Welcome to the Scripture Memorizer program!!!!!!\n");

        // Loop to display and hide words
        bool run = true;
        while (run) {
            scriptureObject.Display();
            Console.Write("\nSelect number of words to hide (default is 3 with just pressing enter) or type 'quit' to quit the program ");
            string input = Console.ReadLine();

            if (input == "quit") {
                run = false;
            }
            else if (input == "") {
                scriptureObject.HideWords(3);
            }
            else {
                scriptureObject.HideWords(int.Parse(input));
            }
            Console.WriteLine();
        }

    }
}
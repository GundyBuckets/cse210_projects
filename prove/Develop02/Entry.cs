using System.ComponentModel;
using System.Runtime.CompilerServices;

// Represents a journal entry
public class Entry
{
    public string _prompt;     // The prompt for the journal entry
    public string _entryDate;  // The date the entry was created
    public string _entry;      // The user's written entry

    // Gets the current date and stores it in _entryDate
    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _entryDate = theCurrentTime.ToShortDateString();
    }

    // Generates a random journal prompt and stores it in _prompt
    public void GeneratePrompt()
    {
        List<string> journalPrompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a challenge you faced recently and how you overcame it.",
            "What is something you’re looking forward to in the next week?",
            "Write about a time when you felt proud of yourself.",
            "What’s a new skill you would like to learn and why?",
            "Reflect on a recent conversation that had a meaningful impact on you.",
            "How do you manage stress? Write about the techniques that work for you.",
            "Describe a person who has influenced your life in a positive way.",
            "What does success mean to you?",
            "Write about your goals for the next year. How will you achieve them?"
        };

        // Selects a random prompt from the list
        Random random = new Random();
        int randomIndex = random.Next(journalPrompts.Count);
        _prompt = journalPrompts[randomIndex];
    }
}

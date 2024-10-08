public class Journal
{
    // List to store entries in the journal
    public List<Entry> _entries = new();

    // Method to save journal entries to a file
    public void SaveFile(List<Entry> entries, string filename)
    {
        // Create and use a StreamWriter to write entries to a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write each entry's date, prompt, and text to the file
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._entryDate}|{entry._prompt}|{entry._entry}");
            }
        }

        // Clear the entries list after saving to avoid duplication
        entries.Clear();
    }

    // Method to load journal entries from a file
    public List<Entry> LoadFile(string filename)
    {
        // Read all lines from the specified file
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Create a new list to hold the loaded entries
        List<Entry> entries = new();

        // Loop through each line in the file
        foreach (string line in lines)
        {
            // Split the line into parts using the '|' delimiter
            string[] parts = line.Split("|");
            
            // Create a new entry and assign its properties based on the file data
            Entry entry = new();
            entry._entryDate = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            // Add the entry to the entries list
            entries.Add(entry);
        }

        // Return the loaded entries
        return entries;
    }

    // Method to display all journal entries in the console
    public void DisplayEntries(List<Entry> entries)
    {
        // Loop through each entry and print the date, prompt, and entry content
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry._entryDate} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._entry}\n");
        }
    }

    // Method to create a new journal entry
    public Entry WriteEntry()
    {
        // Create a new entry
        Entry entry = new();

        // Set the current date on the entry
        entry.GetDate();

        // Generate a random prompt for the entry
        entry.GeneratePrompt();

        // Display the prompt to the user
        Console.WriteLine(entry._prompt);
        Console.Write("> ");

        // Capture the user's input as the journal entry
        entry._entry = Console.ReadLine();

        // Return the newly created entry
        return entry;
    }
}

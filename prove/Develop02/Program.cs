using System;
using System.IO;

// I used w3 schools a lot as a reference

// To go beyond the core requirements, I wrote SaveFile() to also clear the currently existing entries
// in order to clear up memory while to program is running. I also added lines telling the user when the 
// program is saving and loading the entries.
class Program
{
    static void Main(string[] args)
    {
        // Create a new Journal object to handle journal entries
        Journal journal = new();

        // A flag to control the while loop and keep the program running
        int running = 1;

        // Loop to display options to the user and handle their selection
        while (running == 1)
        {
            // Display the menu options to the user
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");     // Add a new journal entry
            Console.WriteLine("2. Display");   // Display all saved journal entries
            Console.WriteLine("3. Load");      // Load journal entries from file
            Console.WriteLine("4. Save");      // Save journal entries to file
            Console.WriteLine("5. Quit");      // Exit the program
            Console.Write("What would you like to do? ");

            // Read the user's input and convert it to an integer
            int option = int.Parse(Console.ReadLine());

            // Handle the user's menu choice based on the selected option
            if (option == 1)
            {
                // Option 1: Write a new journal entry and add it to the list
                journal._entries.Add(journal.WriteEntry());
            }
            else if (option == 2)
            {
                // Option 2: Display all existing journal entries
                journal.DisplayEntries(journal._entries);
            }
            else if (option == 3)
            {
                // Option 3: Load journal entries from a file named "Journal.txt"
                journal._entries = journal.LoadFile("Journal.txt");
                Console.WriteLine("Loading files to be displayed...");
            }
            else if (option == 4)
            {
                // Option 4: Save current journal entries to a file named "Journal.txt"
                journal.SaveFile(journal._entries, "Journal.txt");
                Console.WriteLine("Saving entries and clearing cache...");
            }
            else if (option == 5)
            {
                // Option 5: Quit the program by setting the running flag to 0
                Console.WriteLine("You are now leaving the program, have a nice day!");
                running = 0;
            }
        }
    }
}
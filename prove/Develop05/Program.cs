using System;

class Program
{
    static void Main(string[] args)
    {
        // List to store all goals
        List<Goal> goalList = new();

        // Variable to control the main program loop
        bool running = true;

        // Manager for handling goal-related operations such as saving/loading
        GoalManager manager = new();

        // Array of inspirational quotes to display randomly
        string[] inspirationalQuotes = {
            "The journey of a thousand miles begins with a single step. - Lao Tzu",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "Don't watch the clock; do what it does. Keep going. - Sam Levenson",
            "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
            "Dream big and dare to fail. - Norman Vaughan",
            "Hardships often prepare ordinary people for an extraordinary destiny. - C.S. Lewis",
            "Act as if what you do makes a difference. It does. - William James",
            "The best way to predict the future is to create it. - Abraham Lincoln",
            "It always seems impossible until it's done. - Nelson Mandela",
            "Don't let yesterday take up too much of today. - Will Rogers"
        };

        // Display a random inspirational quote at the start
        Random random = new Random();
        int index = random.Next(inspirationalQuotes.Length);
        Console.WriteLine(inspirationalQuotes[index]);
        Console.WriteLine();

        // Main program loop
        while (running) 
        {
            // Display total points and menu options
            Console.WriteLine($"You have {manager.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1") 
            {
                // Create a new goal
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goals");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();

                // Get goal details from the user
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                // Add the selected type of goal to the goal list
                if (goalChoice == "1") 
                {
                    goalList.Add(new SimpleGoal(points, name, description));
                }
                else if (goalChoice == "2") 
                {
                    goalList.Add(new EternalGoal(points, name, description));
                }
                else if (goalChoice == "3") 
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int toComplete = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goalList.Add(new ChecklistGoal(toComplete, bonus, points, name, description));
                }
                Console.WriteLine();
            }
            else if (choice == "2") 
            {
                // List all goals with display formatting
                int i = 1;
                foreach (Goal goal in goalList) 
                {
                    Console.WriteLine($"{i}. {goal.GetDisplayFormat()}");
                    i++;
                }
                Console.WriteLine();
            }
            else if (choice == "3") 
            {
                // Save goals to a file
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                Console.WriteLine();

                manager.Save(goalList, fileName);
                goalList.Clear();
            }
            else if (choice == "4") 
            {
                // Load goals from a file
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                Console.WriteLine();

                goalList.Clear();
                goalList = manager.Load(fileName);
            }
            else if (choice == "5") 
            {
                // Record the completion a a goal
                List<Goal> tempGoals = new();
                int i = 1;
                foreach (Goal goal in goalList) 
                {
                    // Add incomploete goals to a temporary list
                    if (!goal.IsComplete()) 
                    {
                        tempGoals.Add(goal);
                        Console.WriteLine($"{i}. {goal.GetName()}");
                        i++;
                    }
                }
                Console.Write("Which goal did you accomplish? ");
                int accomplish = int.Parse(Console.ReadLine());
                int pointsEarned = tempGoals[accomplish - 1].RecordEvent();
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                manager.AddPoints(pointsEarned);
                Console.WriteLine($"You now have {manager.GetTotalPoints()} points.\n");
            }
            else if (choice == "6") 
            {
                // Exit the program
                running = false;
            }
        }

    }
}
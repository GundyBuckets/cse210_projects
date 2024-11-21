using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new();

        bool running = true;

        GoalManager manager = new();

        while (running) {
            Console.WriteLine($"You have {manager.GetPoints()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goals");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();

                // Getting Goal Info
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalChoice == "1") {
                    goalList.Add(new SimpleGoal(points, name, description));
                }
                else if (goalChoice == "2") {
                    goalList.Add(new EternalGoal(points, name, description));
                }
                else if (goalChoice == "3") {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int toComplete = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goalList.Add(new ChecklistGoal(toComplete, bonus, points, name, description));
                }
                Console.WriteLine();
            }
            else if (choice == "3") {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                Console.WriteLine();

                manager.Save(goalList, fileName);
                goalList.Clear();
            }
            else if (choice == "4") {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                Console.WriteLine();

                goalList.Clear();
                goalList = manager.Load(fileName);
            }
            else if (choice == "6") {
                running = false;
            }
        }

    }
}
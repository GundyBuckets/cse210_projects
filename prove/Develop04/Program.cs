using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Spinner
        /*
        Activity spinnerTest = new();
        spinnerTest.Spinner();
        */

        // Testing the Activity Display Methods
        /*
        Activity displayTest = new Activity("This is a test description", "Test Type");
        displayTest.DisplayStartMessage();
        displayTest.Spinner();
        displayTest.DisplayEndMessage();
        */
        

        // Testing Listing class methods
        /*
        Listing listingTest = new Listing(listingPrompts, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listingTest.GetRandomPrompt();
        listingTest.DisplayStartMessage();
        Console.WriteLine(listingTest.GetDisplayPrompt());
        listingTest.Spinner();
        listingTest.ListItems();
        */

        // Testing Breathing class
        /*
        Breathing breathingTest = new Breathing();
        breathingTest.DisplayStartMessage();
        breathingTest.Spinner();
        Console.Write("Get ready...");
        breathingTest.Countdown(5);
        breathingTest.StartBreathingCycle();
        breathingTest.DisplayEndMessage();
        */

        // Testing Reflection class
        /*
        Reflection reflectionTest = new Reflection(reflectionPrompts, reflectionQuestions);
        reflectionTest.SetDisplayPrompt();
        reflectionTest.DisplayStartMessage();
        reflectionTest.Spinner();
        Console.WriteLine(reflectionTest.GetDisplayPrompt());
        reflectionTest.Spinner();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(reflectionTest.GetTimer() / 1000);
        while (startTime <= futureTime) {
            Console.Write(reflectionTest.GetRandomQuestion());
            reflectionTest.Spinner();
            startTime = DateTime.Now;
        }
        reflectionTest.DisplayEndMessage();
        */
        
        // Questions and prompts for the activities
        List<string> reflectionPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        List<string> reflectionQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorit thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        List<string> listingPrompts = ["Who are the people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

        // Creating the activity objects
        Breathing justBreathe = new Breathing();
        Reflection timeToReflect = new Reflection(reflectionPrompts, reflectionQuestions);
        Listing listingTime = new Listing(listingPrompts);

        bool running = true;

        while (running) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 1) {
                // When the user selects the breating activity
                Console.Clear();
                justBreathe.DisplayStartMessage();
                justBreathe.StartBreathingCycle();
                justBreathe.DisplayEndMessage();
                Console.Clear();
            }
            else if (selection == 2) {
                // When the user selects the reflecting activity
                Console.Clear();
                timeToReflect.DisplayStartMessage();
                timeToReflect.SetDisplayPrompt();
                timeToReflect.StartReflectionCycle();
                timeToReflect.ResetQuestions(reflectionQuestions);
                timeToReflect.DisplayEndMessage();
                Console.Clear();
            }
            else if (selection == 3) {
                Console.Clear();
                listingTime.SetRandomPrompt();
                listingTime.DisplayStartMessage();
                listingTime.StartListingCycle();
                listingTime.DisplayEndMessage();
                Console.Clear();
            }
            else {
                running = false;
            }
        }
    }
}
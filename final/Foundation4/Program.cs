using System;

class Program
{
    static void Main(string[] args)
    {
        // Making all the excercises into a list
        List<Activity> activities = new();
        Activity running = new Running(30, 2.5);
        Activity cycling = new Cycling(120, 10);
        Activity swimming = new Swimming(7, 60);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
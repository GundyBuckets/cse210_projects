using System;

class Program
{
    static void Main(string[] args)
    {
        // Making a Lecture Object
        Address lectureAddress = new Address("742 Evergreen Terrace", "Springfield", "IL");
        Lecture lecture = new Lecture("How to get a girlfriend", "Joe is going to give a lecture to help lonely guys get a girlfried",
                                      "12/5/2026", "5:00 pm", lectureAddress, "Joe Mama", 55000);
        Console.WriteLine("First, the Lecture Object");
        Console.WriteLine("Short Details");
        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine("Standard Details");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();

        // Making a Reception Object
        Address receptionAddress = new Address("1313 Mockingbird Lane", "Mockingbird Heights", "CA");
        Reception reception = new Reception("Wedding of Joe and Mary", "Come join Joe and Mary for a very special day!", "1/11/2111", "3:00 am", receptionAddress, "jointhewedding@company.com");

        Console.WriteLine("Second, the Reception Object");
        Console.WriteLine("Short Details");
        Console.WriteLine(reception.ShortDetails());
        Console.WriteLine("Standard Details");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();

        // Making an Outdoor object
        Address outdoorAddress = new Address("221 Baker Street", "London", "UK");
        Outdoor outdoor = new Outdoor("Camping Tips", "Want to learn some camping basics? This event is for you!", "2/4/2012", "6:00 pm", outdoorAddress, "Sunny");

        Console.WriteLine("Third, the Outdoor Object");
        Console.WriteLine("Short Details");
        Console.WriteLine(outdoor.ShortDetails());
        Console.WriteLine("Standard Details");
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
    }
}
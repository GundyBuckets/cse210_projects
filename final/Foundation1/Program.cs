using System;

class Program
{
    static void Main(string[] args)
    {
        // Making first video
        Video firstvid = new Video("Ultimate Hiking Guide: 10 Must-Know Trails", "TrailBlazer Acventures", 842);
        firstvid.AddComment("MountainExplorer23", "Great video! The trail difficulty ratings are so helpful!");
        firstvid.AddComment("NatureLover92", "Thos scenic views are breathtaking");
        firstvid.AddComment("GearGeek", "Awesome breakdown of reccomended gear!");

        firstvid.DisplayVideoInfo();
        firstvid.DisplayComments();
        Console.WriteLine();

        // Making second video

        Video secondvid = new Video("Cooking Secrets: Perfect Pasta Every Time", "Chef Maria's Kitchen", 613);
        secondvid.AddComment("FoodieLife", "I've been struggling with pasta for years. Thse tips are game-changers!");
        secondvid.AddComment("HomeCook2000", "The al dente technique is spot on. Learned something new today!");
        secondvid.AddComment("ItalianCuisine", "Authentic techniques. As an Italian, I approve of the tutorial!");

        secondvid.DisplayVideoInfo();
        secondvid.DisplayComments();
        Console.WriteLine();

        // Making third video

        Video thirdvid = new Video("Tech Unboxed: Latest Smartphone Comparison", "TechRevolution", 1205);
        thirdvid.AddComment("GadgetGuru", "Comprehensive review! Really helps in making a purchasing decision");
        thirdvid.AddComment("PhoneFanatic", "Can't believe how in-depth this comparison is. Subscribed");
        thirdvid.AddComment("BudgetTech", "Great breakdown of features vs price. Exactly what I was looking for.");

        thirdvid.DisplayVideoInfo();
        thirdvid.DisplayComments();
    }
}
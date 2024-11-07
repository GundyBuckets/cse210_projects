public class Breathing : Activity {
    // Constructors
    public Breathing() : base("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing"){}

    // Methods
    public void StartBreathingCycle() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimer());

        while (startTime <= endTime) {
            Console.Write("\nBreathe in...");
            Countdown(5);
            Console.Write("\nBreath out...");
            Countdown(5);
            Console.WriteLine();
            startTime = DateTime.Now;
        }
    }

}
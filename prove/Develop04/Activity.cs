public class Activity {
    // Attributes
    private int _timer;
    private string _description;
    private string _type;

    // Constructors
    public Activity(string descriptor, string type){
        _description = descriptor;
        _type = type;
    }

    // Methods
    public void DisplayStartMessage() {
        Console.WriteLine($"Welcome to the {_type} Activity!\n");
        Console.WriteLine(_description, "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _timer = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
    }

    public void DisplayEndMessage() {
        Console.WriteLine("Well done!!!");
        Spinner();
        Console.WriteLine($"You have completed another {_timer} seconds of the {_type} Activity");
        Spinner();
    }

    public void Spinner(int time = 5) {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        while (startTime < futureTime) {
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            startTime = DateTime.Now;
        }
        Console.WriteLine();
    }

    public int GetTimer() {
        return _timer;
    }
    public void Countdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
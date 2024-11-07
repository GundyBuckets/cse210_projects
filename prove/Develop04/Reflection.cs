public class Reflection : Activity {
    // Attributes
    private List<string> _prompts;
    private string _displayPrompt;
    private List<string> _questions;
    private List<string> _notViewedQuestions;
    private List<string> _notUsedPrompts;
    
    // Constructors
    public Reflection(List<string> prompts, List<string> questions) : base ("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection") {
        _prompts = prompts;
        _notUsedPrompts = prompts;
        _questions = questions;
        _notViewedQuestions = questions;
    }

    public void ResetQuestions(List<string> questions) {
        _notViewedQuestions = questions;
    }

    // For above and beyond, on top of not seeing the same question twice, the user will also
    // not see the same prompt twice until all prompts have been viewed
    public void ResetPrompts(List<string> prompts) {
        _notUsedPrompts = prompts;
    }

    public void SetDisplayPrompt() {
        if (_notUsedPrompts.Count == 0) {
            ResetPrompts(_prompts);
        }
        
        Random rnd = new Random();
        int index = rnd.Next(_notUsedPrompts.Count);
        _displayPrompt = _notUsedPrompts[index];
        _notUsedPrompts.RemoveAt(index);
    }

    public string GetRandomQuestion() {
        if (_notViewedQuestions.Count == 0) {
            ResetQuestions(_questions);
        }
        
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
    }

    public void StartReflectionCycle() {
        Console.WriteLine("Consider the following prompt:\n");
        Console.Write(" --- ");
        Console.Write(GetDisplayPrompt());
        Console.WriteLine(" ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimer());
        while (startTime < futureTime) {
            Console.Write("> ");
            Console.Write(GetRandomQuestion());
            Spinner(15);
            startTime = DateTime.Now;
        }
    }

    public string GetDisplayPrompt() {
        return _displayPrompt;
    }

    public int GetNotViewedCount() {
        return _notViewedQuestions.Count;
    }
}
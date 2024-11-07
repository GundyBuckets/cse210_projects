public class Listing : Activity {
    // Attributes
    private List<string> _prompts;
    private string _displayPrompt;
    private int _listItems;
    
    // Constructors
    public Listing(List<string> promptList) : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing") {
        _prompts = promptList; 
    }
    
    // Methods

    public void SetRandomPrompt() {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        _displayPrompt = _prompts[index];
    }

    public string GetDisplayPrompt() {
        return _displayPrompt;
    }
    
    // ListItems will give the user multiple rows to list their ideas and will count them to be displayed later
    public void ListItems() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimer());
        _listItems = 0;
        while (startTime <= endTime) {
            Console.Write("> ");
            Console.ReadLine();
            _listItems++;
            startTime = DateTime.Now;
        }


    }

    public void StartListingCycle() {

        // Display prompt and give countdown to the user
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetDisplayPrompt()} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        //Start listing items
        ListItems();

        Console.WriteLine($"You listed {_listItems} items!");
    }
}
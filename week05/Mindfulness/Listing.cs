public class Listing : Activity
{
    List<string> _items;
    List<string> _prompts;
    public Listing(string initialMessage, string description, int duration, string finalMessage, List<string> prompts)
        : base(initialMessage, description, duration, finalMessage)
    {
        _items = new List<string>();
        _prompts = prompts;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public void ListingExercise()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage());
        Console.WriteLine(GetDescription());
        Console.WriteLine("How many seconds would you like to practice this exercise? (10 seconds minimum)");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        int time = GetDuration();
        Console.WriteLine("Think about the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            AddItem(input);
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou have listed {_items.Count} items.");
        Console.WriteLine(GetFinalMessage());
        Animation(5);
    }

}
public class Reflection : Activity
{
    private List<string> _Prompts;
    private List<string> _Reflections;

    public Reflection(string initialMessage, string description, int duration, string finalMessage, List<string> prompts, List<string> reflections)
        : base(initialMessage, description, duration, finalMessage)
    {
        _Prompts = prompts;
        _Reflections = reflections;
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }

    private string GetRandomReflection()
    {
        Random random = new Random();
        int index = random.Next(_Reflections.Count);
        return _Reflections[index];
    }
    

    public void StartReflectionExercise()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage());
        Console.WriteLine(GetDescription());
        Console.WriteLine("How many seconds would you like to practice this exercise? (12 seconds minimum)");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("Think about the following prompt:");
        int time = GetDuration();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter when you are ready to reflect on the prompt.");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to the prompt:");
        ShowCountDown(5);
        Console.Clear();
        while (time > 0)
        {
            string reflection = GetRandomReflection();
            Console.Write($"> {reflection} ");
            Animation(6);
            Console.WriteLine("");
            time -= 6;
        }
        Console.WriteLine(GetFinalMessage());
        Animation(5);
    }
}
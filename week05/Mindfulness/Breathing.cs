public class Breathing : Activity
{


    public Breathing(string initialMessage, string description, int duration, string finalMessage)
        : base(initialMessage, description, duration, finalMessage)
    {
    }

    public void StartBreathingExercise()
    {
        Console.Clear();
        Console.WriteLine(GetInitialMessage());
        Console.WriteLine(GetDescription());
        Console.WriteLine("");
        Console.WriteLine("How many seconds would you like to practice this exercise? (10 seconds minimum)");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        int time = GetDuration();
        Console.WriteLine("");
        string[] sizes = { ".", "o", "O", "0", "O", "o", "." }; // Ciclo de expansión y contracción
        int frameDelay = 1000;

        while (time > 0)
        {
            for (int i = 0; i < sizes.Length / 2 + 1; i++)
            {
                Console.Write($"\rBreath in...   {sizes[i]}");
                Thread.Sleep(frameDelay);
            }

            Console.WriteLine("");
            for (int i = sizes.Length / 2; i < sizes.Length; i++)
            {
                Console.Write($"\rBreath out...  {sizes[i]}");
                Thread.Sleep(frameDelay);
            }
            Console.WriteLine("");
            time -= 8;
        }
        Console.WriteLine("");
        Console.WriteLine(GetFinalMessage());
        Animation(5);
    }
}  
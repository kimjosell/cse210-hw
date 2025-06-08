public class Activity
{
    private string _initialMessage;
    private string _Description;
    private int _duration;
    private string _finalMessage;

    public Activity(string initialMessage, string description, int duration, string finalMessage)
    {
        _initialMessage = initialMessage;
        _Description = description;
        _duration = duration;
        _finalMessage = finalMessage;
    }

    public string GetInitialMessage()
    {
        return _initialMessage;
    }

    public string GetDescription()
    {
        return _Description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetFinalMessage()
    {
        return _finalMessage;
    }
    public void Animation(int seconds)
    {
        for (int i = 0; i <= seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }

    }

    public void SetDuration(int duration)
    {
        if (duration > 0)
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Duration must be a positive number.");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i <= seconds; i++)
        {
            int timeLeft = seconds - i;
            Console.Write($"\rYou may begin in: {timeLeft}");
            Thread.Sleep(1000);
        }
    }


}
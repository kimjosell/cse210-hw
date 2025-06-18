using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateOnly(2023, 10, 1), 30, 5.0);
        Cycling cycling = new Cycling(new DateOnly(2023, 10, 2), 45, 20.0);
        Swimming swimming = new Swimming(new DateOnly(2023, 10, 3), 60, 1.5);

        Activity[] activities = { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
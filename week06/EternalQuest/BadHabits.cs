using System.Runtime.CompilerServices;

public class BadHabits : Goal
{
    public BadHabits(string name, string description, string points)
        : base(name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description}) --- bad habit;";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"For that bad habit you lost {_points} points.");
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} --- (Bad habit) You will lose points.";
    }
}
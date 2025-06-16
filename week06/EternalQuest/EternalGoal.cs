public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_shortName}' recorded! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";
    } 
}
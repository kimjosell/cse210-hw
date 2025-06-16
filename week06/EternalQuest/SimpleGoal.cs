public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
            return $"[X] {_shortName} ({_description}) - {_points} points";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) - {_points} points";
        }
    }
}
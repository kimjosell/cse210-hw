public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Goal '{_shortName}' progress updated! You have completed {_amountCompleted} out of {_target}.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points and a bonus of {_bonus} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} --- {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) --- {_amountCompleted}/{_target};";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) --- {_amountCompleted}/{_target}";
        }
    }

    public int GetBonus()
    {
        return _bonus;
    }
}
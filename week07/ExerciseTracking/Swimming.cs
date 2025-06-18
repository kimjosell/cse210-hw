public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateOnly date, int lengthInMinutes, double laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Assuming each lap is 50 meters
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lenghtInMinutes) * 60; // km/h
    }

    public override double GetPace()
    {
        return _lenghtInMinutes / GetDistance(); // minutes per km
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Swimming ({_lenghtInMinutes} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }
}
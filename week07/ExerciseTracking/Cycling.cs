public class Cycling : Activity
{
    private double _speedInKilometersPerHour;

    public Cycling(DateOnly date, int lengthInMinutes, double speedInKilometersPerHour)
        : base(date, lengthInMinutes)
    {
        _speedInKilometersPerHour = speedInKilometersPerHour;
    }

    public override double GetDistance()
    {
        return (_speedInKilometersPerHour / 60) * _lenghtInMinutes; // km
    }

    public override double GetSpeed()
    {
        return _speedInKilometersPerHour; // km/h
    }

    public override double GetPace()
    {
        return 60 / _speedInKilometersPerHour; // minutes per km
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Cycling ({_lenghtInMinutes} min): Distance: {GetDistance():F2} km, Speed: {_speedInKilometersPerHour:F2} km/h, Pace: {GetPace():F2} min/km";
    }
}
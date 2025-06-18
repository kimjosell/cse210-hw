public class Running : Activity
{
    private double _distanceInKilometers;

    public Running(DateOnly date, int lengthInMinutes, double distanceInKilometers)
        : base(date, lengthInMinutes)
    {
        _distanceInKilometers = distanceInKilometers;
    }

    public override double GetDistance()
    {
        return _distanceInKilometers;
    }

    public override double GetSpeed()
    {
        return (_distanceInKilometers / _lenghtInMinutes) * 60; // km/h
    }

    public override double GetPace()
    {
        return _lenghtInMinutes / _distanceInKilometers; // minutes per km
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Running ({_lenghtInMinutes} min): Distance: {_distanceInKilometers} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km";
    }
}
public abstract class Activity
{
    protected DateOnly _date;
    protected int _lenghtInMinutes;


    public Activity(DateOnly date, int lenghtInMinutes)
    {
        _date = date;
        _lenghtInMinutes = lenghtInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();

}
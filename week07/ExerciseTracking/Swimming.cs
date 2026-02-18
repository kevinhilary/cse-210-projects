using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double km = (_laps * LapLengthMeters) / 1000;
        double miles = km * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
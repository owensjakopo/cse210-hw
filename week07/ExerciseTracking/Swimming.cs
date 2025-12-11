using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (GetDurationInMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return GetDurationInMinutes() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Swimming ({GetDurationInMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km\n";
    }
}
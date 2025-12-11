using System;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetDurationInMinutes() / 60);
    }

    public override double GetPace()
    {
        return GetDurationInMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return $"\n{GetDate():dd MMM yyyy} Running ({GetDurationInMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
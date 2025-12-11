using System;

public class Cycling : Activity
{
    public double _distanceInKilometers { get; set; }

    private readonly double _duration;

    public Cycling(DateTime date, int durationInMinutes, double distanceInKilometers)
        : base(date, durationInMinutes)
    {
        _duration = durationInMinutes;
        _distanceInKilometers = distanceInKilometers;
    }

    public override double GetDistance()
    {
        return _distanceInKilometers;
    }

    public override double GetDurationInMinutes()
    {
        return _duration;
    }

    public override double GetSpeed()
    {
        return _distanceInKilometers / (GetDurationInMinutes() / 60.0);
    }

    public override double GetPace()
    {
        return _distanceInKilometers > 0 ? GetDurationInMinutes() / _distanceInKilometers : 0;
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetDurationInMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
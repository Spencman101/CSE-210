using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override string Distance()
    {
        return $"{_distance} miles";
    }

    public override string Speed()
    {
        double speed = _distance / (GetDuration() / 60.0);
        return ($"{speed:F1} mph");
    }

    public override string Pace()
    {
        double pace = GetDuration() / _distance;
        return ($"{pace:F1} min per mile");
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) - Distance: {Distance()}, Speed: {Speed()}, Pace: {Pace()}";
    }
}
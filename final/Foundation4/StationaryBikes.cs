using System;

public class StationaryBikes : Activity
{
    private int _speed;

    public StationaryBikes(string date, int duration, int speed)
    : base(date, duration)
    {
        _speed = speed;
    }

    public override string Distance()
    {
        double distance = _speed * (GetDuration() / 60.0);
        return ($"{distance:F1} mph");
    }

    public override string Speed()
    {
        return $"{_speed} mph";
    }

    public override string Pace()
    {
        double distance = _speed * (GetDuration() / 60.0);
        double pace = GetDuration() / distance;
        return ($"{pace:F1} min per mile");
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Stationary Biking ({GetDuration()} min) - Distance: {Distance()}, Speed: {Speed()}, Pace: {Pace()}";
    }
}
using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
    : base(date, duration)
    {
        _laps = laps;
    }

    public override string Distance()
    {
        double distance = (_laps * 50) / 1000 * 0.62;
        return ($"{distance:F1} mph");
    }

    public override string Speed()
    {
        double distanceInMiles = (_laps * 50) / 1000 * 0.62;
        double speed = distanceInMiles / (GetDuration() / 60.0); // Convert minutes to hours
        return $"{speed:F2} mph";
    }

    public override string Pace()
    {
        double distance = (_laps * 50) / 1000 * 0.62;
        double pace = GetDuration() / distance;
        return ($"{pace:F1} min per mile");
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min) - Distance: {Distance()}, Speed: {Speed()}, Pace: {Pace()}";
    }
}
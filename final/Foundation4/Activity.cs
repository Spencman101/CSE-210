using System;

public abstract class Activity
{
    private string _date;

    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string GetDate()
    {
        return _date;
    }

    public virtual int GetDuration()
    {
        return _duration;
    }
    
    public virtual string Distance()
    {
        return ("Distance: ");
    }

    public virtual string Speed()
    {
        return ("Speed: ");
    }

    public virtual string Pace()
    {
        return ("Pace: ");
    }

    public abstract string GetSummary();
}
using System;

public class OutdoorGatherings : Event
{

    private string _weather;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, Address address, string weather)
        : base(eventTitle, description, date, time, address)
        {
            _weather = weather;
        }

    public override void FullDetails()
    {
        base.FullDetails();

        Console.WriteLine(_weather);
    }

    public override void ShortDescription()
    {
        Console.WriteLine("Outdoor Gathering");
        
        base.ShortDescription();
    }
}
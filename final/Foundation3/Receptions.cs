using System;

public class Receptions : Event
{

    private bool RSVP;

    public Receptions(string eventTitle, string description, string date, string time, Address address, bool rsvp)
        : base(eventTitle, description, date, time, address)
    {
        RSVP = rsvp;
    }
    
    public override void FullDetails()
    {
        base.FullDetails();

        if (RSVP)
            Console.WriteLine("RSVP Needed.");
        else
            Console.WriteLine("RSVP Not Needed.");
    }

    public override void ShortDescription()
    {
        Console.WriteLine("Reception");
        
        base.ShortDescription();
    }
}
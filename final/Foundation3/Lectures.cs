using System;

public class Lectures : Event
{

    private string _speaker;

    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails()
    {
        base.FullDetails();

        Console.WriteLine($"{_speaker}\nCapacity: {_capacity}");
    }

    public override void ShortDescription()
    {
        Console.WriteLine("Lecture");
        
        base.ShortDescription();
    }
}
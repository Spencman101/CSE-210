using System;

public class Event
{

    private string _eventTitle;

    private string _description;

    private string _date;

    private string _time;

    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Standard Details: {_eventTitle}\n{_description}\n{_date} {_time}\nAddress: {_address.GetAddress()}");
    }

    public virtual void FullDetails()
    {
        Console.WriteLine($"Full Details: {_eventTitle}\n{_description}\n{_date} {_time}\nAddress: {_address.GetAddress()}");
    }

    public virtual void ShortDescription()
    {
        Console.WriteLine($"Short Description: {_eventTitle} {_date}");
    }
    
}
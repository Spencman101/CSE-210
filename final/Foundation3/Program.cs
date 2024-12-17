using System;

class Program
{
    static void Main(string[] args)
    {

        // string eventTitle, string description, string date, string time, string speaker, int capacity)
        Address event1Address = new Address("123 Multiverse Ave", "Neverwinter", "Sword Coast", "Faerûn");
        Lectures event1 = new Lectures("Monsters of The Multiverse", "A time to learn of the creatures around you, and the dangers they pose.", "10/30/3000", "3:00 AM", event1Address, "Mordenkainen", 666);
        event1.StandardDetails();
        event1.ShortDescription();
        event1.FullDetails();

        Address event2Address = new Address("2509 1st St E", "West Fargo", "North Dakota", "United States of America");
        OutdoorGatherings event2 = new OutdoorGatherings("Neighborhood Grill", "A place to go for good food, and even better times!", "7/15/2024", "5:00 PM", event2Address, "Sunny");
        event2.StandardDetails();
        event2.ShortDescription();
        event2.FullDetails();

        Address event3Address = new Address("440 S 2nd West", "Rexburg", "Idaho", "United States of America");
        Receptions event3 = new Receptions("Wedding Reception", "A perfect place to congradulate the new happy couple!", "12/16/2024", "4:00 PM", event3Address, true);
        event3.StandardDetails();
        event3.ShortDescription();
        event3.FullDetails();
    }
}
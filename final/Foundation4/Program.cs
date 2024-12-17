using System;

class Program
{
    static void Main()
    {
        Running run = new Running("03 Nov 2022", 30, 3.0);
        StationaryBikes bike = new StationaryBikes("03 Nov 2022", 30, 12);
        Swimming swim = new Swimming("03 Nov 2022", 30, 40);

        var activities = new List<Activity> { run, bike, swim };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
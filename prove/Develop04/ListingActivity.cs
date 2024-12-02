public class ListingActivity : Activity 
{

    private List<string> _positiveList;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        name = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = 50;

        // Set other values here that are unique to the Reflecting Activity
        _positiveList = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heros?"];
    }

    public void RunListingActivity()
    {
        
    }

    public void DisplayPrompt()
    {

    }

    public void UpdateList()
    {

    }
}
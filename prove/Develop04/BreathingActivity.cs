public class BreathingActivity : Activity 
{

    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        name = "Breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        duration = 0;

        // Set other values here that are unique to the Breathing Activity
    }

    public void RunBreathingActivity()
    {
        DisplayStart();

    }

    public void DisplayPrompt()
    {

    }

    public void BreathingCountdown()
    {

    }
}
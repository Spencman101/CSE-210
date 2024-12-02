public class ReflectingActivity : Activity 
{

    private List<string> _prompts;

    private List<string> _questions;
    
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        name = "Reflecting";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        duration = 50;

        // Set other values here that are unique to the Reflecting Activity
        _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];
    }

    public void RunReflectingActivity()
    {
        
    }

    public void RandomPrompt()
    {
        Random random = new Random();
        int selected_index = random.Next(0,_prompts.Count);
        Console.WriteLine(_prompts[selected_index]);
    }

    public void RandomQuestion()
    {
        Random random = new Random();
        int selected_index = random.Next(0,_questions.Count);
        Console.WriteLine(_questions[selected_index]);

    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
    }

    public override string DisplayStatus()
    {
        return $"[{_timesCompleted}/{_requiredTimes}] {Name} - {Description}";
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _requiredTimes)
        {
            return Points + _bonusPoints;
        }
        return Points;
    }
}

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isCompleted;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _isCompleted = false;
    }
    public override void RecordEvent(GoalManager manager)
    {
        if (_isCompleted)
        {
            Console.WriteLine("This goal is already completed! Set another one!");
            return;
        }

        _amountCompleted += 1;

        if (IsComplete())
        {
            manager.SetScore(GetPoints() + _bonus);
            Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {_bonus} points!");
        }
        else
        {
            manager.SetScore(GetPoints());
            Console.WriteLine($"Progress: {_amountCompleted}/{_target}. Keep going!");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            _isCompleted = true;
            return true;
        }
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~{GetName()}~{Getdescription()}~{GetPoints()}~{_amountCompleted}~{_target}~{_bonus}";
    }
    public override string GetDetailString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        string details = base.GetDetailString();
        return $"{checkBox} {details} — Progress: {_amountCompleted}/{_target}";
    }
}

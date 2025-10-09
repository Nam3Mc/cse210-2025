public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isCompleted = false)
        : base(shortName, description, points)
    {
        _isComplete = isCompleted;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override void RecordEvent(GoalManager manager)
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already completed, choose another one!");
            return;
        }

        manager.SetScore(GetPoints());
        _isComplete = true;
        Console.WriteLine($"Goal \"{GetName()}\" completed! You earned {GetPoints()} points!");
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~{GetName()}~{Getdescription()}~{GetPoints()}~{IsComplete()}";
    }
    public override string GetDetailString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        string details = base.GetDetailString();
        return $"{checkBox} {details}";
    }
}

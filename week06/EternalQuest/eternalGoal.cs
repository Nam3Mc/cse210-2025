public class EternalGoal : Goal
{
    private int _completedTimes;
    private const int _bonus = 200;
    public override bool IsComplete()
    {
        return false;
    }
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _completedTimes = 0;
    }
    public override void RecordEvent(GoalManager manager)
    {
        _completedTimes++;
        manager.SetScore(GetPoints());
        Console.WriteLine($"Goal \"{GetName()}\" completed {_completedTimes} times! +{GetPoints()} points");
        if (_completedTimes == 5)
        {
            _completedTimes = 0;
            manager.SetScore(_bonus);
            Console.WriteLine($"Bonus unlocked! You received {_bonus} extra points!");
        }
    }
    
    
    
    
    public override string GetStringRepresentation()
    {
        return $"EternalGoal~{GetName()}~{Getdescription()}~{GetPoints()}~{_completedTimes}";
    }
    public override string GetDetailString()
    {
        return $"[ ] {base.GetDetailString()} (Completed {_completedTimes} times)";
    }
}

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string Getdescription()
    {
        return _description;
    }
    public abstract void RecordEvent(GoalManager manager);
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}
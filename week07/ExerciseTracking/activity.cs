public abstract class Activity
{
    private DateTime _date;
    private float _length;
    public Activity(DateTime date, float length)
    {
        _date = date;
        _length = length;
    }
    public float GetLength()
    {
        return _length;
    }
    abstract public float GetDistance();
    abstract public float GetSpeed();
    abstract public float GetPace();
    public virtual void GetSummary()
    {
        Console.Write($"{_date:dd MMM yyyy} ({_length})");
    }
}
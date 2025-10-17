public class Running : Activity
{
    private float _distance;
    public Running(DateTime date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        float timeHours = GetLength() / 60f;
        return _distance / timeHours;
    }
    public override float GetPace()
    {
        return GetLength() / _distance;
    }
    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"- Running | Distance: {GetDistance():F2} km | Speed: {GetSpeed():F2} kph | Pace: {GetPace():F2} min/km");
    }
}

public class Cycling : Activity
{
    private float _speed; 
    public Cycling(DateTime date, float length, float speed) : base(date, length)
    {
        _speed = speed;
    }
    public override float GetDistance()
    {
        float timeHours = GetLength() / 60f;
        return _speed * timeHours;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        // Pace = minutes per kilometer
        return 60f / _speed;
    }
    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"- Cycling | Distance: {GetDistance():F2} km | Speed: {GetSpeed():F2} kph | Pace: {GetPace():F2} min/km");
    }
}

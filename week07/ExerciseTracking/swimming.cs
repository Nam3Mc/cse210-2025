public class Swimming : Activity
{
    private int _laps;
    private const float _metersPerLap = 50f;
    public Swimming(DateTime date, float length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return (_laps * _metersPerLap) / 1000f;
    }
    public override float GetSpeed()
    {
        float timeHours = GetLength() / 60f;
        return GetDistance() / timeHours;
    }
    public override float GetPace()
    {
        return 60f / GetSpeed();
    }
    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine($"- Swimming | Distance: {GetDistance():F2} km | Speed: {GetSpeed():F2} kph | Pace: {GetPace():F2} min/km");
    }
}

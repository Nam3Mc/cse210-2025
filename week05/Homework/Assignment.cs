public class Assignment
{
    private string _studentName;
    private string _topic;
    public string GetSummary()
    {
        return $"{_studentName}, {_topic}";
    }
    public string GetName()
    {
        return $"{_studentName}";
    }
    public Assignment(string studenName, string topic)
    {
        _studentName = studenName;
        _topic = topic;
    }
}
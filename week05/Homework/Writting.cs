public class Writing : Assignment
{
    private string _title;

    public string GetWriringInformation()
    {
        return $"{GetSummary()} \n{_title} By {GetName()}";
    }
    public Writing(string studenName, string topic, string title) : base(studenName, topic)
    {
        _title = title;
    }
}
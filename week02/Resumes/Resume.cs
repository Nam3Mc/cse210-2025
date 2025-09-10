public class Resume
{
    public string _FirstName;
    public string _LastName;
    public List<Job> _Jobs;

    public void ShowJobs()
    {
        Console.WriteLine($"{_FirstName} {_LastName}");
        Console.WriteLine(_Jobs[0]);
    }
}
public class Job
{
    public string _Company;
    public string _JobTitle;
    public string _StartYear;
    public string _EndYear;
    public void ShowJobDetails()
    {
        Console.WriteLine($"{_JobTitle}, {_Company}, {_StartYear}-{_EndYear}");
    }

    public void CreateNewResume()
    {
        Console.WriteLine("Hi, What is your Name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hi, What is your Last Name?");
        string lastName = Console.ReadLine();
        Resume newPerson = new Resume();
        newPerson._FirstName = name;
        newPerson._LastName = lastName;
        Console.WriteLine($"{newPerson._FirstName}, Please add the following information:");
        Console.WriteLine("What company did you work for:");
        string company = Console.ReadLine();
        Console.WriteLine("What was your title:");
        string jobTitle = Console.ReadLine();
        Console.WriteLine("What Year did you started to work there:");
        string startYear = Console.ReadLine();
        Console.WriteLine("What Year did you end to work there:");
        string endYear = Console.ReadLine();
        Job newJob = new Job();
        newJob._Company = company;
        newJob._JobTitle = jobTitle;
        newJob._StartYear = startYear;
        newJob._EndYear = endYear;

        newPerson.ShowJobs();
    }
}
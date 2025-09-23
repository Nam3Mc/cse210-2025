public class Activity
{
    private string _name;
    private string _description;
    private int? _duration;
    public void GerReadyMessage(string message, int sec)
    {
        int duration = sec;
        string dots = ".";
        int cursorTop = Console.CursorTop;
        while (duration != 0)
        {
            Console.SetCursorPosition(0, cursorTop);
            Console.WriteLine($"{message.PadRight(Console.WindowWidth)}\n{dots}");
            Thread.Sleep(1000);
            dots += ".";
            duration -= 1;
        }
    }
    public void LoadingMessage()
    {
        List<string> letters = ["L", "O", "A", "D", "I", "N", "G"];
        foreach (string letter in letters)
        {
            Console.Write(letter + " ");
            Thread.Sleep(5000 / 7);
        }
        Console.WriteLine();
    }
    public void CountDown(int seconds)
    {
        int count = seconds;
        while (count != 0)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            count--;
        }
    }
    public string GetName()
    {
        string name = _name;
        return name;
    }
    public Activity(string name, string description, int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long in seconds, would you like for your session?: ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        LoadingMessage();
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        LoadingMessage();
    }
}
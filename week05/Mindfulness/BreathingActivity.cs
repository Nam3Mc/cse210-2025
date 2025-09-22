public class BreathingActivity : Activity
{
    UserInput newInput = new UserInput();
    public BreathingActivity(string name, string description, int duration = 0) : base(name, description, duration)
    {
    }
    public void BreathIn(int sec)
    {
        int count = sec;
        while (count != 0)
        {
            Console.Write($"Breath in {count}");
            Thread.Sleep(1000);
            count--;
            Console.Write("\r");
        }
        Console.WriteLine("\rBreath in...");
    }
    public void BreathOut(int sec)
    {
        int count = sec;
        while (count != 0)
        {
            Console.Write($"Now Breath out {count}");
            Thread.Sleep(1000);
            count--;
            Console.Write("\r");
        }
        Console.WriteLine("\rNow Breath out...");
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        string time = Console.ReadLine();
        int seconds = newInput.InputHandler(time);
        SetDuration(seconds);
        Console.Clear();
        GerReadyMessage("Get Ready!", 5);
        Console.WriteLine();
        while (seconds >= 0)
        {
            int inTime = Math.Min(5, seconds);
            BreathIn(inTime);
            seconds -= inTime;
            if (seconds == 0)
            {
                break;
            }
            int outTime = Math.Min(5, seconds);
            BreathOut(outTime);
            seconds -= inTime;
            if (seconds == 0)
            {
                break;
            }
            Console.WriteLine();
        }
        string name = GetName();
        GerReadyMessage("\nWell done!!", 5);
        Console.WriteLine($"Youihave completed {time} seconds of the {name} Activity");
        LoadingMessage();
        Console.Clear();
    }
}
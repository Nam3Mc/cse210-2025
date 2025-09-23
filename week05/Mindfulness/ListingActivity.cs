public class ListingActivity : Activity
{
    // Removed unused field '_count'
    private List<string> _prompts;
    UserInput newInput = new UserInput();


    public ListingActivity(string name, string description, int duration = 0) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think about something you are grateful for today.",
            "Recall a mistake you made recently.",
            "Think of a moment when you made someone smile.",
            "Focus on a fear that is holding you back.",
            "Think about something you are holding onto that no longer serves you.",
            "Reflect on how you have grown over the past year.",
            "Think about a habit you want to improve or change.",
            "Picture a place or activity that brings you peace.",
            "Think about whether you are living according to your values.",
            "Imagine one small step you could take toward a long-term goal.",
        };
    }
    public void DisplayPront()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count() - 1);
        Console.WriteLine($"--- {_prompts.ElementAt(index)} ---");
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        string time = Console.ReadLine();
        int seconds = newInput.InputHandler(time);
        int count = 0;
        Console.Clear();
        GerReadyMessage("Get Ready!", 5);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayPront();
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Task<string> inputTask = Task.Run(() => Console.ReadLine());
            if (Task.WhenAny(inputTask, Task.Delay(seconds * 1000)).Result == inputTask)
            {
                string response = inputTask.Result;
                if (!string.IsNullOrWhiteSpace(response))
                {
                    count += 1;
                }
            }
        }
        Console.WriteLine($"You have provided {count} for this question");
        DisplayEndingMessage();
    }
}
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    UserInput newInput = new UserInput();
    public ReflectingActivity(string name, string description, int duration = 0) : base(name, description, duration)
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
        _questions = new List<string>
        {
            "Why does this thing matter to you right now?",
            "How does it impact your daily life?",
            "What would your day be like without it?",
            "What lesson did you learn from it?",
            "How could you approach the same situation differently next time?",
            "Did this mistake change the way you see yourself or others?",
            "How did that moment make you feel?",
            "What did you learn about the power of kindness?",
            "How can you create more moments like that?",
            "Where do you think this fear comes from?",
            "What would your life look like without this fear?",
            "What small step can you take to face it?",
            "Why is it difficult to let it go?",
            "How would your life improve if you released it?",
            "What is one small action you can take to start letting go?",
            "What is the biggest change you notice in yourself?",
            "What challenge helped you grow the most?",
            "How can you continue this growth moving forward?",
            "Why do you want to change this habit?",
            "What triggers this habit in your daily life?",
            "What small replacement habit could you start today?",
            "What emotions do you feel when you are there?",
            "Why does this bring you calmness compared to other things?",
            "How can you bring more of this peace into your daily life?",
        };
    }
    public void DisplayPront()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count() - 1);
        Console.WriteLine($"--- {_prompts.ElementAt(index)} ---");
    }
    public void DisplayQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine($"{_questions.ElementAt(index)} ");
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
        Console.WriteLine();
        DisplayPront();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
        Console.Clear();
        int questionDuration = 10;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            DateTime questionEnd = DateTime.Now.AddSeconds(Math.Min(questionDuration, (endTime - DateTime.Now).TotalSeconds));
            Task<string> inputTask = Task.Run(() => Console.ReadLine());
            if (Task.WhenAny(inputTask, Task.Delay(questionDuration * 1000)).Result == inputTask)
                {
                    string response = inputTask.Result;
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                    count += 1;
                    }
                }
        }
        string name = GetName();
        GerReadyMessage("\nWell done!!", 5);
        Console.WriteLine($"You have completed {time} seconds of the {name} Activity");
        LoadingMessage();
        Console.Clear();
    }
}
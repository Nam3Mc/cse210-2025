using System.Diagnostics.CodeAnalysis;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    string answer = "";
    UserInput newInput = new UserInput();
    FilesHandler handler = new FilesHandler();
    public void LoadingMessage(string word)
    {
        char[] letters = word.ToCharArray();
        foreach (char letter in letters)
        {
            Console.Write(letter + " ");
            Thread.Sleep(5000 / 10);
        }
        Console.WriteLine();
    }
    public void GoalType()
    {
        Console.WriteLine("\nThe types of goals are: \n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goals \n");
        Console.Write("Which type of goal would you like to create? ");
    }
    public void Options()
    {
        DisplayPlayerInfo();
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.Write("Type you number option Or 'Q' to finish: \n");
    }
    public GoalManager()
    {
        _goals = new List<Goal>();
    }
    public void SetScore(int points)
    {
        _score += points;
    }
    public void Start()
    {
        while (answer.ToUpper() != "Q")
        {
            Options();
            answer = Console.ReadLine();
            int answerInt = newInput.InputHandler(answer);
            if (answerInt == 1)
            {
                CreateGoal();
            }
            if (answerInt == 2)
            {
                ListGoalDetails();
            }
            if (answerInt == 3)
            {
                SaveGoal();
            }
            if (answerInt == 4)
            {
                LoadGoal();
            }
            if (answerInt == 5)
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} Points\n");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }
    public void CreateGoal()
    {
        GoalType();
        answer = Console.ReadLine();
        int goalType = newInput.InputHandler(answer);
        if (goalType == 1 || goalType == 2)
        {
            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            int intPoints = newInput.InputHandler(points);
            SimpleGoal goal = new SimpleGoal(
                name, description, intPoints
            );
            _goals.Add(goal);
        }
        if (goalType == 3)
        {
            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            int intPoints = newInput.InputHandler(points);
            Console.Write("How many times does this goal needs to be completed for a bonus? ");
            string target = Console.ReadLine();
            int intTarget = newInput.InputHandler(target);
            Console.Write("What is the bonus associated with this goal? ");
            string bonus = Console.ReadLine();
            int intBonus = newInput.InputHandler(bonus);
            ChecklistGoal goal = new ChecklistGoal(
                name, description, intPoints, intTarget, intBonus, 0
            );
            _goals.Add(goal);
        }
    }
    public void RecordEvent()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()} ");
            index += 1;
        }
        Console.Write("What event do you want to Record?\n Type the number: ");
        string userGoal = Console.ReadLine();
        index = newInput.InputHandler(userGoal);
        Goal newGoal = _goals.ElementAt(index - 1);
        newGoal.RecordEvent(this);
    }
    public void SaveGoal()
    {
        Console.Write("what will be your file name? ");
        string fileName = Console.ReadLine();
        handler.SaveToFile(_goals, _score, fileName);
        LoadingMessage("SAVING...");
        Console.WriteLine("Your goals were save.");
    }
    public void LoadGoal()
    {
        Console.Write("What is the name of the file to load? ");
        string fileName = Console.ReadLine();
        _goals = handler.LoadFile(fileName, this);
        LoadingMessage("LOADING...");
        Console.WriteLine("Your goals were loaded successfully.");
    }
}
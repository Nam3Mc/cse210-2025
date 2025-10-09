using System.Data;

public class FilesHandler
{
    public void SaveToFile(List<Goal> goals, int score, string name)
    {
        string fileName = ($"{name}.txt");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public List<Goal> LoadFile(string filename, GoalManager manager)
    {
        List<Goal> goals = [];
        string[] lines = System.IO.File.ReadAllLines(filename);
        manager.SetScore(int.Parse(lines[0]));
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            if (goalType == "SimpleGoal")
            {
                bool isCompleted = parts[4].Trim().ToLower() == "true";
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isCompleted);
                goals.Add(simpleGoal);
            }
            if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                goals.Add(eternalGoal);
            }
            if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                goals.Add(checklistGoal);
            }
        }
        return goals;
    }
}
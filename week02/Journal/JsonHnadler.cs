using System.IO;
using System.Text.Json;

public class JsonHandler
{

    static public (int key, int questionsCount) ChoseATopics()
    {
        string jsonString = File.ReadAllText("questions.Json");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        Dictionary<string, List<string>> topics = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(jsonString);

        int index = 1;
        int chosenTopic = -1;
        Console.WriteLine("Chose one Topic!");

        foreach (var topic in topics)
        {
            Console.WriteLine($"{index}. {topic.Key}");
            index++;

        }
        string userIntput = Console.ReadLine();
        chosenTopic = int.Parse(userIntput);
        int numberOfQuestions = topics.ElementAt(chosenTopic - 1).Value.Count;

        return (chosenTopic - 1, numberOfQuestions);
    }

    static public (string answer, string questions) AnswerARandonQuestion(int indexKey, int maxIndex)
    {
        string jsonString = File.ReadAllText("questions.Json");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        Dictionary<string, List<string>> topics = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(jsonString);
        Random random = new Random();
        int index = random.Next(0, maxIndex);
        string randonQuestion = topics.ElementAt(indexKey).Value.ElementAt(index);
        Console.WriteLine(randonQuestion);
        string answer = Console.ReadLine();

        return (answer, randonQuestion);
     }
}
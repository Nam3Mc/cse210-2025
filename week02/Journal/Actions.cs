public class Actions
{
    public static Journal CreateJournal()
    {
        Journal newJournal = new Journal();

        (int tipicIndex, int questionMaxIndex) data = JsonHandler.ChoseATopics();
        (string answer, string randonQuestion) = JsonHandler.AnswerARandonQuestion(data.tipicIndex, data.questionMaxIndex);
        newJournal._Date = DateTime.Now.ToString();
        newJournal._Question = randonQuestion;
        newJournal._Answer = answer;
        return newJournal;
    }
    public static void DisplayJournal(List<Journal> journals)

    {
        Console.WriteLine($"Here we have {journals.Count} records");

        if (journals.Count == 0)
        {
            Console.WriteLine("Your Journal has no records. Let's write something interesting!");
        }
        else
        {
            foreach (var record in journals)
            {
                Console.WriteLine($"This Record was created at {record._Date}");
                Console.WriteLine($"Your question was: {record._Question}");
                Console.WriteLine($"Your answer was: {record._Answer}");
                Console.WriteLine();
            }
        }
    }

    public static void SaveJournal(List<Journal> journalList, string nameToSave)
    {
        FilesHandler.SaveToFile(journalList, nameToSave);
    }

    public static List<Journal> LoadJournal(string fileToLoad)
    {
        return FilesHandler.LoadFile(fileToLoad);
    }
}
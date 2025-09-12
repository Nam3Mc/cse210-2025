public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList()
    {
        return $"{GetSummary()} \nSection: {_textbookSection} - Problems: {_problems}";
    }
    public Math(string studenName, string topic, string textBookSection, string problem) : base(studenName, topic)
    {
        _textbookSection = textBookSection;
        _problems = problem;
    }
}
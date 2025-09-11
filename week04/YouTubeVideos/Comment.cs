public class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _commentText = comment;
    }
    public void DisplayData()
    {
        Console.WriteLine($"By: {_userName} \n{_commentText}");
    }
}
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments;
    public Video(string title, string author, int length, List<Comment> commentsList)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = commentsList;
    }
    public void DisplayData()
    {
        int mins = 0;
        int sec = 0;
        int duration = _length;
        while (duration >= 60)
        {
            mins++;
            duration -= 60;
        }
        sec = duration;
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nDuration: {mins}:{sec} min");
    }
    public List<Comment> GetComents()
    {
        return _comments;
    }


}
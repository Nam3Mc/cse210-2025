using Newtonsoft.Json;
public class Generator
{
    public Video RandomVideo()
    {
        Random random = new Random();
        string titleString = File.ReadAllText("titles.json");
        string authorString = File.ReadAllText("authors.json");
        string commentsString = File.ReadAllText("comments.json");

        var titles = JsonConvert.DeserializeObject<List<string>>(titleString);
        var authors = JsonConvert.DeserializeObject<List<string>>(authorString);
        var comments = JsonConvert.DeserializeObject<List<string>>(commentsString);

        int titleIndex = random.Next(0, titles.Count());
        int authorsIndex = random.Next(0, authors.Count());
        int length = random.Next(300, 1200);

        List<Comment> randomComents = [];
        while (randomComents.Count() < 4)
        {
            int commentsIndex = random.Next(0, comments.Count());
            int nameIndex = random.Next(0, authors.Count());
            Comment comment = new Comment(authors.ElementAt(nameIndex), comments.ElementAt(commentsIndex));
            randomComents.Add(comment);
        }
        Video RandonVideo = new Video(titles.ElementAt(titleIndex), authors.ElementAt(authorsIndex), length, randomComents);

        return RandonVideo;
    }
}
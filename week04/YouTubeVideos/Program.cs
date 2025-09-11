using System;
class Program
{
    static void Main(string[] args)
    {
        Generator ng = new Generator();
        List<Video> videosList = [];
        while (videosList.Count() < 4)
        {
            Video newVideo = ng.RandomVideo();
            videosList.Add(newVideo);
        }
        foreach (var video in videosList)
        {
            List<Comment> comments = video.GetComents();
            video.DisplayData();
            Console.WriteLine($"This Video has the following {comments.Count()} Comments: ");
            foreach (var coment in comments)
            {
                coment.DisplayData();
            }
            Console.WriteLine();
        }
    }
}
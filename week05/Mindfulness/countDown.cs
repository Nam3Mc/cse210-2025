public class CountDonw
{
    public void Loading(string message, int sec)
    {
        int duration = sec;
        string dots = ".";

        while (duration != 0)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine(dots);
            Thread.Sleep(1000);

            string dot = ".";
            dots = dots + dot;
            duration -= 1;
        }
    }
}
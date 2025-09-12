
using System;

class Program
{
    static void Main(string[] args)
    {
        Math newMath = new Math("Samuel Bennet", "Multiplication", "7.3", "8-19");
        Console.WriteLine(newMath.GetHomeworkList());
        Writing newWriting = new Writing("Mary Waters", "European Hystory", "The causes of World War II");
        Console.WriteLine(newWriting.GetSummary());
    }
}
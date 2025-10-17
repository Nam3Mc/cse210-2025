using System;

class Program
{
    static void Main(string[] args)
    {
        var running1 = new Running(new DateTime(2025, 10, 5), 25, 4.2f);  
        var running2 = new Running(new DateTime(2025, 10, 9), 50, 9.3f);
        var running3 = new Running(new DateTime(2025, 10, 13), 75, 14.5f);
        running1.GetSummary();
        running2.GetSummary();
        running3.GetSummary();

        // 🚴 Cycling activities (speed in km/h)
        var cycling1 = new Cycling(new DateTime(2025, 10, 4), 60, 22.5f);  
        var cycling2 = new Cycling(new DateTime(2025, 10, 8), 90, 27.8f);
        var cycling3 = new Cycling(new DateTime(2025, 10, 12), 120, 31.2f);
        cycling1.GetSummary();
        cycling2.GetSummary();
        cycling3.GetSummary();

        // 🏊 Swimming activities (laps in 50m pool)
        var swimming1 = new Swimming(new DateTime(2025, 10, 3), 30, 25);  
        var swimming2 = new Swimming(new DateTime(2025, 10, 7), 45, 45);
        var swimming3 = new Swimming(new DateTime(2025, 10, 11), 60, 70);
        swimming1.GetSummary();
        swimming2.GetSummary();
        swimming3.GetSummary();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int grade = -1;
        string sign = "";

        while (grade != 0)
        {
            Console.WriteLine("Type 0 to exit");
            Console.Write("Type your Grade: ");

            string StringGrade = Console.ReadLine();
            grade = int.Parse(StringGrade);

            if (StringGrade.Length > 1)
            {
                if (int.Parse(StringGrade[1].ToString()) >= 7)
                {
                    sign = "+";
                }
                else if (int.Parse(StringGrade[1].ToString()) < 3)
                {
                    sign = "-";
                }
            }
            else
            {
                sign = "";
            }

            if (grade >= 90)
            {
                Console.WriteLine($"You got an A{sign}");
            }
            else if (grade >= 80)
            {
                Console.WriteLine($"You got an B{sign}");
            }
            else if (grade >= 70)
            {
                Console.WriteLine($"You got an C{sign}");
            }
            else if (grade >= 60)
            {
                Console.WriteLine($"You got an D{sign}");
            }
            else if (grade > 0)
            {
                Console.WriteLine($"You got an F{sign}");
            }
            sign = "";
        }
    }
}
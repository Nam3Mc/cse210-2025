using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        List<int> numbers = new List<int>();
        int total = 0;
        int biggest = 0;
        int smaller = 999999;

        while (userInput != "0")
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            userInput = Console.ReadLine();
            numbers.Add(int.Parse(userInput));
        }
        foreach (int number in numbers)
        {
            total += number;
            if (number > biggest)
            {
                biggest = number;
            }
            else if (number > 0 && number < smaller)
            {
                smaller = number;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total / numbers.Count}");
        Console.WriteLine($"The largest number is: {biggest}");
        numbers.Sort();
        Console.WriteLine($"The smallest positive number is: {smaller}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlayin = "YES";
        while (keepPlayin == "YES")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 1000);
            Console.WriteLine("Guest the magic Number");
            Console.WriteLine("What is yout guest: ");
            string userInput = Console.ReadLine();
            int guest = int.Parse(userInput);
            int tries = 1;
            {
                while (guest != number)
                {
                    if (guest > number)
                    {
                        Console.WriteLine(" The magic Number is lower");
                    }
                    else
                    {
                        Console.WriteLine(" The magic number is higher");
                    }
                    Console.WriteLine("What is yout guest: ");
                    userInput = Console.ReadLine();
                    guest = int.Parse(userInput);
                    tries++;
                }
            }
            Console.WriteLine($" You guest it, the magic number is {guest}");
            Console.WriteLine($" You tried {tries} times");
            Console.WriteLine("Would you like to keep playin?");
            Console.WriteLine("Type YES or NO");
            keepPlayin = Console.ReadLine();
        }
    }
}
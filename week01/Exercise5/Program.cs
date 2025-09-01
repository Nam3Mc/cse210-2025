using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your Favorite Number: ");
            string userFavoriteNumber = Console.ReadLine();
            return int.Parse(userFavoriteNumber);
        }
        static void SquareNumber(string userName, float favoriteNumber)
        {
            float squaredNumer = favoriteNumber * favoriteNumber;
            Console.WriteLine($"{userName}, the square of your number is {squaredNumer}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        SquareNumber(name, number);
    }
}
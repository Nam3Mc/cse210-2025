class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        while (userInput != 5)
        {
            userInput = Menu.MenuOptions();
            Menu.OptionsHandler(userInput);
        }
    }
}
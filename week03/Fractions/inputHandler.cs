public class UserInput
{
    public int InputHandler(string input)
    {
        int backUp = 0;
        if (input.Trim().ToUpper() == "Q")
        {
            Console.WriteLine("Exiting program...");
            return backUp;
        }
        if (int.TryParse(input, out backUp))
        {
            return backUp;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number or 'Q' to quit.");
            return backUp;
        }
    }
}
using System.Runtime.InteropServices;

public class InputTaker
{
    public void Menu()
    {
        string exit = "";
        int output = 0;
        FractionOutput newOutput = new FractionOutput();
        while (exit.ToUpper() != "Q")
        {
            Console.WriteLine("Type 'Q' to exit!");
            Console.WriteLine("1. Will you provie just NUMERATOR");
            Console.WriteLine("2. Will you provie BOTH");
            string input = Console.ReadLine();
            UserInput newIntput = new UserInput();
            output = newIntput.InputHandler(input);

            if (output == 1)
            {
                Console.WriteLine("Type NUMERATOR: ");
                string userInput = Console.ReadLine();
                int numerator = newIntput.InputHandler(userInput);
                newOutput.OnlyNumerator(numerator);
            }
            else if (output == 2)
            {
                Console.WriteLine("Type NUMERATOR: ");
                string userInput = Console.ReadLine();
                Console.WriteLine("Type DENOMINATOR: ");
                string secondInput = Console.ReadLine();
                int numerator = newIntput.InputHandler(userInput);
                int denominator = newIntput.InputHandler(secondInput);
                newOutput.NumeratorAndDenominator(numerator, denominator);
            }
            else
            {
                Console.WriteLine($"You typed {input} and only numers or 'Q' are valid");
            }


        }
    }
}
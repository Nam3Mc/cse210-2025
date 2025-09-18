public class Menu
{
    string answer = "";
    UserInput newInput = new UserInput();
    CountDonw newCountDonw = new CountDonw();
    public void Options()
    {
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine();
        Console.Write("Type you number option Or 'Q' to finish: ");
        Console.WriteLine();
    }
    public void OptionHandler()
    {
        while (answer.ToUpper() != "Q")
        {
            Options();
            answer = Console.ReadLine();
            int answerInt = newInput.InputHandler(answer);
            if (answerInt == 1)
            {
                Console.Clear();
                Console.WriteLine("Wlcome to the Breathing Activity.\n");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.\n");
                Console.Write("How long in seconds, would you like for your session?: ");
                string time = Console.ReadLine();
                int seconds = newInput.InputHandler(time);
                newCountDonw.Loading("Get Ready", seconds);
            }
            if (answerInt == 2)
            {
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
            }
            if (answerInt == 3)
            {
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
        }
    }
}
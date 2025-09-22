public class Menu
{
    string answer = "";
    UserInput newInput = new UserInput();
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
                string name = "Breathing";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.\n";
                BreathingActivity newActivity = new BreathingActivity(name, description);
                newActivity.Run();
            }
            if (answerInt == 2)
            {
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                string name = "Reflecting";
                ReflectingActivity newActivity = new ReflectingActivity(name, description);
                newActivity.Run();}
            if (answerInt == 3)
            {
                string description = "This activity will help you reflect in the good thins in your life by having you list as many things as can in a certain area.";
                string name = "Listing";
                ListingActivity newActivity = new ListingActivity(name, description);
                newActivity.Run();
            }
        }
    }
}
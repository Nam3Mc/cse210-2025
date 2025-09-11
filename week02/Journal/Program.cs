// For this program I have save all the qeustions in a json file
// instead of having the questions in any other part of the code
// i have separated the pronts by topict and from the json file
// we first have displayed the topic and the user can chose what
// topic they want to write about, and the depending in the topic 
// a random question is displayed
// the program also has the ability to save the information in a
// csv file which can be open in excel.

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
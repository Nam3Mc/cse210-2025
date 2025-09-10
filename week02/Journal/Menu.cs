 using System.IO;

public class Menu
{
    public static List<Journal> newList = new List<Journal>();
    static public int MenuOptions()
    {
        Console.WriteLine("Please select one of the following questions");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What Would you like to do?  ");
        string chose = Console.ReadLine();
        int option;
        if (int.TryParse(chose, out option))
        {
            if (option >= 1 && option <= 5)
            {
                return option;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.\n");
                option = -1;
                return option;
            }
        }
        Console.WriteLine("Invalid input. Please enter a number.\n");
        return option;
    }

    static public void OptionsHandler(int option)
    {
        if (option == 1)
        {
            Journal newJournal = Actions.CreateJournal();
            newList.Add(newJournal);
            Console.WriteLine();
        }

        else if (option == 2)
        {
            Actions.DisplayJournal(newList);
            Console.WriteLine();
        }
        else if (option == 3)
        {
            Console.WriteLine("Loading this file will delete all the records you have create.");
            Console.WriteLine("Type 'YES' or 'NO' Do you want to continue?");

            string appove = Console.ReadLine();
            if (appove.ToUpper() == "YES")
            {
                Console.WriteLine("Type the file name including the extention. Example .csv/ .txt / etc.");
                string fileToRead = Console.ReadLine();
                newList.Clear();
                newList = Actions.LoadJournal(fileToRead);
                Console.WriteLine();
            }
            else if (appove.ToUpper() == "NO")
            {
                Console.WriteLine();
            }
        }
        else if (option == 4)
        {
            Console.WriteLine("What name do ypu want to give to your journal file?");
            string nameOfFile = Console.ReadLine();
            Actions.SaveJournal(newList, nameOfFile);
            Console.WriteLine($"The file was save as {nameOfFile}.csv.");
            Console.WriteLine();
        }

    }

}
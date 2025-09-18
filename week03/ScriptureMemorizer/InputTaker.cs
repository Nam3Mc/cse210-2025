using Newtonsoft.Json.Linq;

public class InputTaker
{
    public async Task Menu()
    {

        string exit = "";
        int output = 0;

        while (exit.ToUpper() != "Q")
        {
            Console.WriteLine("Welcome to memorizing verses.");
            Console.WriteLine("Type Q to finish");
            Console.WriteLine("1. To Have a randon Verse to memorize.");
            Console.WriteLine("2. To Have multiple random verses to memorize.");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Q")
                break;
            UserInput newIntput = new UserInput();
            output = newIntput.InputHandler(input);
            if (output == 1)
            {
                Console.Clear();
                DataHandler newData = new DataHandler();
                VerseGenerator randonVerse = new VerseGenerator();
                JObject newVerse = await randonVerse.GetRandonVerse();
                Reference reference = newData.ReferenceHandler(newVerse);
                List<Word> words = newData.WordHandler(newVerse);
                Scripture scripture = newData.ScriptureHandler(reference, words);
                while (input.ToUpper() != "Q")
                {
                    string verseReference = reference.GetData(reference);
                    Console.Write($"{verseReference} : ");
                    foreach (var word in words)
                    {
                        Console.Write(word.GetText() + " ");
                    }
                    Hider hider = new Hider();
                    hider.HideRandomWords(words);
                    Console.WriteLine();
                    if (words.All(w => w.GetStatus()))
                    {
                        Console.Clear();
                        Console.WriteLine($"{verseReference} : ");
                        foreach (var word in words)
                        {
                            Console.Write(word.GetText() + " ");
                        }
                        Console.Write("\n");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("Type Q to finish or ENTER to continue:");
                    input = Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (output == 2)
            {
                Console.Clear();
                DataHandler newData = new DataHandler();
                VerseGenerator randonVerse = new VerseGenerator();
                JObject newVerse = await randonVerse.GetRandonVerse();
                Reference reference = newData.ReferenceHandler(newVerse);
                List<Word> words = newData.WordHandler(newVerse);

                string book = reference.GetBook();
                int chapter = reference.GetChapter();
                int startVerse = reference.GetVerse();
                string upperVerseLink = $"{book}%20{chapter}:{startVerse + 1}";
                string lowerVerseLink = $"{book}%20{chapter}:{startVerse - 1}";

                JObject upperVerse = await randonVerse.GetSpecificVerse(upperVerseLink);
                List<Word> upperVerseWords = newData.WordHandler(upperVerse);
                reference.UpdateReference(reference, startVerse + 1);
                
                foreach (Word i in upperVerseWords)
                {
                    words.Add(i);
                }

                Scripture scripture = newData.ScriptureHandler(reference, words);
                while (input.ToUpper() != "Q")
                {
                    string verseReference = reference.GetData(reference);
                    Console.Write($"{verseReference} : \n");
                    foreach (var word in words)
                    {
                        Console.Write(word.GetText() + " ");
                    }
                    Hider hider = new Hider();
                    hider.HideRandomWords(words);
                    if (words.All(w => w.GetStatus()))
                    {
                        Console.Clear();
                        Console.WriteLine($"{verseReference} : ");
                        foreach (var word in words)
                        {
                            Console.Write(word.GetText() + " ");
                        }
                        Console.Write("\n");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Type Q to finish or ENTER to continue:");
                    input = Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
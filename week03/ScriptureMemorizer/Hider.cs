public class Hider
{
    public void HideRandomWords(List<Word> words)
    {
        Random random = new Random();
        int wordsToChange = random.Next(2, 3);
        int count = 0;

        while (count < wordsToChange)
        {
            if (words.All(w => w.GetStatus()))
            {
                count = wordsToChange;
            }
            int index = random.Next(0, words.Count);
            if (!words[index].GetStatus())
            {
                words[index].Hide();
                count++;
            }
        }
    }
}
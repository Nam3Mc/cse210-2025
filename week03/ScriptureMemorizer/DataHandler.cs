using Newtonsoft.Json.Linq;

public class DataHandler
{
    public List<Word> WordHandler(JObject jObject)
    {
        string verse = jObject["text"].ToString();
        string[] words = verse.Split(" ");
        List<Word> newList = [];
        foreach (var i in words)
        {
            Word newWord = new Word(i);
            newList.Add(newWord);
        }
        return newList;
    }
    public Reference ReferenceHandler(JObject jObject)
    {
        string book = jObject["book"].ToString();
        int chapter = (int)jObject["chapter"];
        int verse = (int)jObject["verse"];
        Reference newReference = new Reference(book, chapter, verse);
        return newReference;
    }
    public Reference TwoVesesReferenceHandler(JObject jObject, int lastVerse)
    {
        string book = jObject["book"].ToString();
        int chapter = (int)jObject["chapter"];
        int verse = (int)jObject["verse"];
        Reference newReference = new Reference(book, chapter, verse, lastVerse);
        return newReference;
    }
    public Scripture ScriptureHandler(Reference reference, List<Word> wordsList)
    {
        Scripture newScripture = new Scripture(reference, wordsList);
        return newScripture;
    }
}
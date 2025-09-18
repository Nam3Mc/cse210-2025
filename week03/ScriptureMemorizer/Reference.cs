public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse, int? endVerse=0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public void UpdateReference(Reference reference, int endVerse)
    {
        reference._endVerse = endVerse;
    }
    public string GetData(Reference reference)
    {
        string book = reference._book;
        int chapter = reference._chapter;
        int verse = reference._verse;
        int? endVerse = reference._endVerse;
        string dataRender = ($"{book} {chapter}: {verse}-{endVerse}");
        return dataRender;
    }
    public string GetBook()
    {
        string book = _book;
        return book;
    }
    public int GetChapter()
    {
        int chapter = _chapter;
        return chapter;
    }
    public int GetVerse()
    {
        int verse = _verse;
        return verse;
    }



}
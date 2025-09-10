using System.Data;

static public class FilesHandler
{
    static public void SaveToFile(List<Journal> records, string name)
    {
        string fileName = ($"{name}.csv");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Journal record in records)
            {
                outputFile.WriteLine($"{record._Date},{record._Question},{record._Answer}");
            }
        }
    }

    static public List<Journal> LoadFile(string filename)
    {
        List<Journal> records = new List<Journal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string record in lines)
        {
            Journal newJournal = new Journal();
            string[] data = record.Split(",");
            newJournal._Date = data[0];
            newJournal._Question = data[1];
            newJournal._Answer = data[2];
            records.Add(newJournal);
        }
        return records;
    }
}
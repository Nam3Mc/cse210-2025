using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class VerseGenerator
{
    public async Task<JObject> GetRandonVerse()
    {
        using var client = new HttpClient();
        string url = "https://bible-api.com/data/web/random";
        var response = await client.GetStringAsync(url);
        var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(response)["random_verse"];
        var randonVerse = (JObject)data;
        return randonVerse;
    }
    public async Task<JObject> GetSpecificVerse(string parameters)
    {
        using var client = new HttpClient();
        string url = $"https://bible-api.com/{parameters}";
        var response = await client.GetStringAsync(url);
        var json = JObject.Parse(response);
        var verse = (JArray)json["verses"];
        var obje = (JObject)verse.ElementAt(0);
        return obje;
    }

}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Rule
{
    public string description { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public bool hidden { get; set; }
    public int page { get; set; }
}


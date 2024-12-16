// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Category
{
    public string id { get; set; }
    public string entryId { get; set; }
    public string name { get; set; }
    public bool primary { get; set; }
}


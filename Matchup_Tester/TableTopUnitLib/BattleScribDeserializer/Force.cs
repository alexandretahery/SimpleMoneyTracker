// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class Force
{
    public List<Rule> rules { get; set; }
    public List<Selection> selections { get; set; }
    public List<Category> categories { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public string entryId { get; set; }
    public string catalogueId { get; set; }
    public int catalogueRevision { get; set; }
    public string catalogueName { get; set; }
}


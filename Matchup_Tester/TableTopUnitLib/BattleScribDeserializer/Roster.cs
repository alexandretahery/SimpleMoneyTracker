// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class Roster
{
    public List<Cost> costs { get; set; }
    public List<CostLimit> costLimits { get; set; }
    public List<Force> forces { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public double battleScribeVersion { get; set; }
    public string generatedBy { get; set; }
    public string gameSystemId { get; set; }
    public string gameSystemName { get; set; }
    public int gameSystemRevision { get; set; }
    public string xmlns { get; set; }
}


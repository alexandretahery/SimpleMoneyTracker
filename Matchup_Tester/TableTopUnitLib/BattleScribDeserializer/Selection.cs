using System.Collections.Generic;

public class Selection
{
    public List<Category> categories { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public string entryId { get; set; }
    public int number { get; set; }
    public string type { get; set; }
    public string from { get; set; }
    public List<Selection> selections { get; set; }
    public List<Rule> rules { get; set; }
    public List<Profile> profiles { get; set; }
    public List<Cost> costs { get; set; }
    public string entryGroupId { get; set; }
    public string group { get; set; }
}


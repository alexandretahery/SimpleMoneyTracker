using System.Collections.Generic;

public class Profile
{
    public List<Characteristic> characteristics { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public bool hidden { get; set; }
    public string typeId { get; set; }
    public string typeName { get; set; }
    public string from { get; set; }
}


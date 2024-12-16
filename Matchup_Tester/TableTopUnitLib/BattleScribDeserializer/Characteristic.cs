// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Characteristic
{
    [JsonProperty("$text")]
    public string text { get; set; }
    public string name { get; set; }
    public string typeId { get; set; }
}


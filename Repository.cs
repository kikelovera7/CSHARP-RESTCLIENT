namespace RequestTask;
using System.Text.Json.Serialization;

public class Repository{
    /* 
        we are going to use the repository class to represent the JSON Object returned by the API GET CALL, so the serializer automatically avoid 
        properties which are not present in the destination class ( in this case Repository class only have one property and that is Name)

        the name property needs to be in lowecase because the JSON Property is represented in that way, then both property should be equals.
        (To avoid this we can use the Json.serialization namespace, and add this tag to the property so we can keep our conventon and name it with Capital Letter
        Name;
        )
     */
    [JsonPropertyName("name")]
    public string Name {get;set;}

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("html_url")]
    public Uri GitHubHomeUrl { get; set; }

    [JsonPropertyName("watchers")]
    public int Watchers { get; set; }

    [JsonPropertyName("homepage")]
    public Uri Homepage { get; set; }


}
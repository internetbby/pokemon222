using System;
using System.Text.Json.Serialization;

public class Pokemon
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("hp")]
    public int Hp { get; set; }

    [JsonPropertyName("type")]

    public string Type { get; set; }
}

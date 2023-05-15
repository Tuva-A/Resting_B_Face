using System.Security.AccessControl;
using System;
using System.Text.Json.Serialization;



public class Species
{
    [JsonPropertyName("name")]
    public int MyProperty { get; set; }
    [JsonPropertyName("classification")]
    public string Classification { get; set; }
    [JsonPropertyName("designation")]
    public string Designation { get; set; }
    [JsonPropertyName("average_height")]
    public int AverageHeight { get; set; }
    [JsonPropertyName("skin_colors")]
    public string SkinColors { get; set; }
    [JsonPropertyName("hair_colors")]
    public string HairColors { get; set; }
    [JsonPropertyName("eye_colors")]
    public string EyeColors { get; set; }
    [JsonPropertyName("average_lifespan")]
    public int AverageLifespan { get; set; }
    [JsonPropertyName("homeworld")]
    public string Homeworld { get; set; }
    [JsonPropertyName("language")]
    public string Language { get; set; }
    [JsonPropertyName("people")]
    public string People { get; set; }
}

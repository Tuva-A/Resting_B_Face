using System;
using System.Text.Json.Serialization;

public class Planets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("rotation_period")]
    public int RotationPeriod { get; set; }
    [JsonPropertyName("orbital_period")]
    public int OrbitalPeriod { get; set; }
    [JsonPropertyName("diameter")]
    public int Diameter { get; set; }
    [JsonPropertyName("climate")]
    public string? Climate { get; set; }
    [JsonPropertyName("gravity")]
    public int Gravity { get; set; }
    [JsonPropertyName("terrain")]
    public string? Terrain { get; set; }
    [JsonPropertyName("surface_water")]
    public int SurfaceWater { get; set; }
    [JsonPropertyName("population")]
    public string? Population { get; set; }
    [JsonPropertyName("residents")]
    public string[]? Residents { get; set; }
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }
}

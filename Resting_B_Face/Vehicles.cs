using System;
using System.Text.Json.Serialization;


public class Vehicles
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("model")]
    public string Model { get; set; }
    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public int CostInCredits { get; set; }
    [JsonPropertyName("length")]
    public int Length { get; set; }
    [JsonPropertyName("crew")]
    public int Crew { get; set; }
    [JsonPropertyName("passangers")]
    public int Passangers { get; set; }
    [JsonPropertyName("cargo_capacity")]
    public int CargoCapacity { get; set; }
    [JsonPropertyName("consumables")]
    public int Consumables { get; set; }
    [JsonPropertyName("pilots")]
    public string Pilots { get; set; }

}

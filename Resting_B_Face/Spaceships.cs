using System;
using System.Text.Json.Serialization;


public class Spaceships
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("model")]
    public string Model { get; set; }
    [JsonPropertyName("manefacturer")]
    public string Manufacturer { get; set; }
    [JsonPropertyName("cost_in_credits")]
    public int CostInCredits { get; set; }
    [JsonPropertyName("length")]
    public int Length { get; set; }
    [JsonPropertyName("max_atmosphering_speed")]
    public int MaxAtmospheringSpeed { get; set; }
    [JsonPropertyName("crew")]
    public int Crew { get; set; }
    [JsonPropertyName("passengers")]
    public int Passengers { get; set; }
    [JsonPropertyName("cargo_capacity")]
    public int CargoCapacity { get; set; }
    [JsonPropertyName("consumables")]
    public int Consumables { get; set; } //in years
    [JsonPropertyName("hyperdrive_rating")]
    public int HyperdriveRating { get; set; }
    [JsonPropertyName("MGLT")]
    public int MGLT { get; set; }
    [JsonPropertyName("starship_class")]
    public string StarshipClass { get; set; }
    [JsonPropertyName("pilots")]
    public string Pilots { get; set; }
    

}


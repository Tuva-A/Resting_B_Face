using System;
using System.Text.Json.Serialization;


public class Films
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("episode_id")]
    public int EpisodeId { get; set; }
    [JsonPropertyName("opening_crawl")]
    public string OpeningCrawl { get; set; }
    [JsonPropertyName("director")]
    public string Director { get; set; }
    [JsonPropertyName("producer")]
    public string Producer { get; set; }
    [JsonPropertyName("release_date")]
    public int ReleaseDate { get; set; }
    [JsonPropertyName("characters")]
    public string Characters { get; set; }
    [JsonPropertyName("planets")]
    public string Planets { get; set; }
    [JsonPropertyName("starships")]
    public string Starships { get; set; }
}

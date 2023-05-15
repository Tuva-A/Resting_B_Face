using System;
using RestSharp;
using System.Text.Json;

RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("planets/5/");
RestResponse response = starwarsClient.GetAsync(request).Result;


Planets p = JsonSerializer.Deserialize<Planets>(response.Content);
if (p != null)
{
    Console.WriteLine(p.Name);
    Console.ReadLine();
}


Console.ReadLine();
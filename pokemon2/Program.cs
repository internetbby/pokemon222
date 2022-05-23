using System;
using System.Text.Json;
using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/pokemon/");


Console.WriteLine("what pokemon do u want?");

string pokemonRequested = Console.ReadLine();

RestRequest pokeRequest = new RestRequest(pokemonRequested);


RestResponse result = await pokeClient.GetAsync(pokeRequest);

Pokemon p = JsonSerializer.Deserialize<Pokemon>(result.Content);

Console.WriteLine("pokemon got" + p.Name + p.Type);

if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    Console.WriteLine("Not found!");
}

Console.ReadLine();




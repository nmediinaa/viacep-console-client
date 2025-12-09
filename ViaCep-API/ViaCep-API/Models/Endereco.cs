using System.Text.Json.Serialization;

namespace ViaCep_API.Models;

public class Endereco
{
    [JsonPropertyName("logradouro")]
    public string Logradouro { get; set; }

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; }

    [JsonPropertyName("uf")]
    public string Uf { get; set; }
    
    [JsonPropertyName("estado")]
    public string Estado { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"Logradouro: {Logradouro}");
        Console.WriteLine($"Bairro: {Bairro}");
        Console.WriteLine($"Uf: {Uf}");
        Console.WriteLine($"Estado: {Estado}");
    }
}
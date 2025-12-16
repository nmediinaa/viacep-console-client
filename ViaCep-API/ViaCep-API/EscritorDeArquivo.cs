using ViaCep_API.Models;

namespace ViaCep_API;

public class EscritorDeArquivo
{

    public void WriterFile(Endereco endereco)
    {
        using(FileStream fs = new FileStream("SearchHistory.txt", FileMode.Append))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"Logradouro: {endereco.Logradouro}");
            writer.WriteLine($"Bairro: {endereco.Bairro}");
            writer.WriteLine($"Uf: {endereco.Uf}");
            writer.WriteLine($"Estado: {endereco.Estado}");
            writer.WriteLine("");
        }
    }
}
using ViaCep_API.Interface;

namespace ViaCep_API.View;

public class Menu : IMenu
{
    public  void ExibirHeader()
    {
        string titulo = "BUSCA BUSCA - API";
        int qntdLetras = titulo.Length;
        
        string simboloDeIgual = string.Empty.PadLeft(qntdLetras, '=');

        Console.WriteLine(simboloDeIgual);
        Console.WriteLine(titulo);
        Console.WriteLine(simboloDeIgual);
        Console.WriteLine("");
    }

    public void ExibirMenu()
    {
        Console.WriteLine("1 - Bucar endereço pelo CEP");
        Console.WriteLine("2 - Histórico de pesquisa");
        Console.WriteLine("");
        Console.WriteLine("Digite sua opção:");
        Console.Write(">>");
    }
}
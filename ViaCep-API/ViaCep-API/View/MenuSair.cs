using ViaCep_API.Interface;

namespace ViaCep_API.View;

public class MenuSair : IMenu
{
    public void ExibirHeader()
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
        Console.WriteLine("Saindo...");
        Environment.Exit(0);
    }
}
using ViaCep_API.Interface;

namespace ViaCep_API.View;

public class MenuHistorico : IMenu
{
    public void ExibirHeader()
    {
        string titulo = "Histórico de Pesquisa";
        int qntdLetras = titulo.Length;
        
        string simboloDeIgual = string.Empty.PadLeft(qntdLetras, '=');

        Console.WriteLine(simboloDeIgual);
        Console.WriteLine(titulo);
        Console.WriteLine(simboloDeIgual);
        Console.WriteLine("");
    }

    public void ExibirMenu()
    {
        Console.WriteLine("Em desenvolvimento...");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
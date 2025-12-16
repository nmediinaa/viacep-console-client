using ViaCep_API.Interface;

namespace ViaCep_API.View;

public class MenuHistorico : IMenu
{
    private LeitorDeArquivo _leitorDeArquivo = new LeitorDeArquivo();
    
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
        _leitorDeArquivo.ReadFile();
        //Console.WriteLine("Em desenvolvimento...");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadLine();
        //Thread.Sleep(2000);
        Console.Clear();
    }
}
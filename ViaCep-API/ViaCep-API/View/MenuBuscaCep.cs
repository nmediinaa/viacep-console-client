using System.Text.Json;
using ViaCep_API.Interface;
using ViaCep_API.Models;

namespace ViaCep_API.View;

public class MenuBuscaCep : IMenu
{

    public void ExibirHeader()
    {
        string titulo = "BUSCA ENDEREÇO";
        int qntdLetras = titulo.Length;
        
        string simboloDeIgual = string.Empty.PadLeft(qntdLetras, '=');

        Console.WriteLine(simboloDeIgual);
        Console.WriteLine(titulo);
        Console.WriteLine(simboloDeIgual);
        Console.WriteLine();
    }

    public void Executar()
    {
        throw new NotImplementedException();
    }


    public void ExibirMenu()
    {
        Console.WriteLine("> Digite um CEP(Sem ponto e sem traços):");
        Console.Write(">>");
        
    }
}
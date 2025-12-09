using System.Text.Json;
using ViaCep_API.Interface;
using ViaCep_API.Models;
using ViaCep_API.View;


using (HttpClient client = new HttpClient())
{
    try
    {
        Dictionary<int, IMenu> menus = new Dictionary<int, IMenu>();
        menus.Add(1, new MenuBuscaCep());
        menus.Add(2, new MenuHistorico());
        
        Menu menuIndex = new();
        while (true)
        {
            menuIndex.ExibirHeader();
            menuIndex.ExibirMenu();
            int cmd = int.Parse(Console.ReadLine()!);

            if (cmd == 1)
            {
                Console.Clear();
                menus[cmd].ExibirHeader();
                menus[cmd].ExibirMenu();
                string cepEscolhido = Console.ReadLine()!;
                Console.Clear();
                string response = await client.GetStringAsync($"https://viacep.com.br/ws" +
                                                              $"/{cepEscolhido}/json/");
        
                var cep = JsonSerializer.Deserialize<Endereco>(response)!;
                cep.Exibir();
                Thread.Sleep(2000);
                Console.Clear();
            } else if (menus.ContainsKey(cmd))
            {
                Console.Clear();
                menus[cmd].ExibirHeader();
                menus[cmd].ExibirMenu();
            }
            else
            {
                Console.WriteLine("Digite uma opção valida!");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

}
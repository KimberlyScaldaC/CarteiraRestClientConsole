using CS_CarteiraRest.Model;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarteiraRestClientConsole
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string baseUrl = "http://localhost:5287/api/Carteiras";

            await GetCarteira(baseUrl);

            var novaCarteira = new Carteira
            {
                Nome = "Kim",
                Moeda = "Cripto",
                Saldo = 100
            };

            await PostCarteira(baseUrl, novaCarteira);

            await GetCarteira(baseUrl);
        }
        static async Task GetCarteira(string url)
        {
            Console.WriteLine("\n Entrou no GetCriptoCoins");
            var response = await client.GetAsync(url);
            //Console.WriteLine("\n Response GET: " + response);
            var carteiras = await response.Content.ReadAsStringAsync();
            //Console.WriteLine("\n criptoCoins GET: " + criptoCoins);
            Console.WriteLine("\n Reposta GET: " + carteiras);
        }

        static async Task PostCarteira(string url, Carteira novaCarteira)
        {
            Console.WriteLine("\n Entrou no PostCriptoCoin");
            var response = await client.PostAsJsonAsync(url, novaCarteira);
            //Console.WriteLine("\n Response POST: " + response);
            var resposta = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\n Reposta POST: " + resposta);
        }

    }
}


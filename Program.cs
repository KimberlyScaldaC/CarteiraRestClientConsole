using CS_CarteiraRest.Model;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarteiraRestClientConsole
{
    internal class Program
    {
        // Criação de uma instância estática do HttpClient para fazer requisições HTTP
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            // URL base da API de carteiras
            string baseUrl = "http://localhost:5287/api/Carteiras";

            // Realiza uma requisição GET para listar as carteiras existentes
            await GetCarteira(baseUrl);

            // Cria uma nova carteira para ser enviada via POST
            var novaCarteira = new Carteira
            {
                Nome = "Kim",
                Moeda = "Cripto",
                Saldo = 100
            };

            // Envia a nova carteira para a API
            await PostCarteira(baseUrl, novaCarteira);

            // Realiza novamente uma requisição GET para verificar se a carteira foi adicionada
            await GetCarteira(baseUrl);
        }

        // Método que realiza uma requisição GET para buscar as carteiras cadastradas
        static async Task GetCarteira(string url)
        {
            // Envia a requisição GET
            var response = await client.GetAsync(url);
            // Lê o conteúdo da resposta como string
            var carteiras = await response.Content.ReadAsStringAsync();
            // Exibe o conteúdo retornado
            Console.WriteLine("\n Resposta GET: " + carteiras);
        }

        // Método que realiza uma requisição POST para cadastrar uma nova carteira
        static async Task PostCarteira(string url, Carteira novaCarteira)
        {
            // Envia a carteira no corpo da requisição como JSON
            var response = await client.PostAsJsonAsync(url, novaCarteira);
            // Lê o conteúdo da resposta como string
            var resposta = await response.Content.ReadAsStringAsync();
            // Exibe a resposta da API (pode ser uma confirmação ou erro)
            Console.WriteLine("\n Resposta POST: " + resposta);
        }

    }
}


namespace CS_CarteiraRest.Model
{
    public class Carteira
    {
        public Carteira()
        {
            Nome = "";
            Moeda = "";
            Saldo = 0;
        }

        public Carteira(string nome, string moeda, decimal saldo)
        {
            Nome = nome;
            Moeda = moeda;
            Saldo = saldo;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Moeda { get; set; }
        public Decimal Saldo { get; set; }
    }
}

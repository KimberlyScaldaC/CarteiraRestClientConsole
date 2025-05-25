namespace CS_CarteiraRest.Model
{
    public class Transacao
    {
        public Transacao()
        {
            Id = 0;
            IdCarteira = 0;
            Tipo = "";
            Valor = 0;
            Data = DateTime.Now;
        }
        public Transacao(int id, int idCarteira, string tipo, decimal valor, DateTime data)
        {
            Id = id;
            IdCarteira = idCarteira;
            Tipo = tipo;
            Valor = valor;
            Data = data;
        }
        
        public int Id { get; set; }
        public int IdCarteira { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; } // "entrada", "saida" ou "transferencia"
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }

    }
}

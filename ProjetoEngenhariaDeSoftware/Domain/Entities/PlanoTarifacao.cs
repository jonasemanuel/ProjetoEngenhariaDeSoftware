using ProjetoEngenhariaDeSoftware.Domain.DomainObjects;

namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class PlanoTarifacao
    {
        public Guid Id { get; }
        public string Valor { get; } //Decimal? String?
        public DataVigencia DataVigencia { get; }

        public PlanoTarifacao(Guid id, string valor, DateTime dataVigencia)
        {
            Id = id;
            Valor = valor;
            DataVigencia = new DataVigencia(dataVigencia);
        }
    }
}

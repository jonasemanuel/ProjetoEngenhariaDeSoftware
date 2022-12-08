using ProjetoEngenhariaDeSoftware.Domain.DomainObjects;

namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class Contrato
    {
        public Guid Id { get; }
        public string Valor { get; } //Decimal? String?
        public DataVigencia DataVigencia { get; }

        public Contrato(Guid id, string valor, DateTime dataVigencia)
        {
            Id = id;
            Valor = valor;
            DataVigencia = new DataVigencia(dataVigencia);
        }
    }
}

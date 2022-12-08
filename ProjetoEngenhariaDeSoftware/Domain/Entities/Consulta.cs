namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class Consulta
    {
        public Cliente Cliente { get; }
        public PlanoTarifacao PlanoTarifacao { get; }
        public Fornecedor Fornecedor { get; }
        public Contrato Contrato { get; }

        public Consulta(Cliente cliente, PlanoTarifacao planoTarifacao, Fornecedor fornecedor, Contrato contrato)
        {
            Cliente = cliente;
            PlanoTarifacao = planoTarifacao;
            Fornecedor = fornecedor;
            Contrato = contrato;
        }

        public override string ToString()
        {
            return $"[Consulta]: Cliente - ${Cliente.Nome} ";
        }
    }
}

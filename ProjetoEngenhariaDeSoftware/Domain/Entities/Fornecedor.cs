namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class Fornecedor
    {
        public Guid Id { get; }
        private string Nome { get; set; }
        private string Descricao { get; set; }

        public Fornecedor(Guid id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public void MudarNome(string nome)
        {
            Nome = nome;
        }

        public void MudarDescricao(string descricao)
        {
            Descricao = descricao;
        }
    }
}

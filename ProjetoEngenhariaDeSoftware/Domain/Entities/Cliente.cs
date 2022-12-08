using ProjetoEngenhariaDeSoftware.Domain.DomainObjects;

namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; }
        public string Nome { get; set; }
        public CNPJ CNPJ { get; }
        private IList<Telefone> Telefones = new List<Telefone> { };
        private IList<Cliente> Clientes = new List<Cliente> { };

        public Cliente(Guid id, string nome, string cnpj)
        {
            Id = id;
            Nome = nome;
            CNPJ = new CNPJ(cnpj);
        }
        
        public void MudarNome(string nome)
        {
            Nome = nome;
        }

        public void AdicionarTelefone(string telefone)
        {
            Telefones.Add(new Telefone(telefone));
        }

        public void AdicionarClient(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
    }
}

using ProjetoEngenhariaDeSoftware.Domain.DomainObjects;

namespace ProjetoEngenhariaDeSoftware.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; }
        public string Email { get; set; }
        public Senha Senha { get; set; }

        public Usuario(Guid id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = new Senha(senha);
        }

        public void TrocarEmail(string email)
        {
            Email = email;
        }

        public void TrocarSenha(string senha)
        {
            Senha = new Senha(senha);
        }
    }
}

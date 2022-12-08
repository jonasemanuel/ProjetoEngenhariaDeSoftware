namespace ProjetoEngenhariaDeSoftware.Domain.DomainObjects
{
    public record Telefone
    {
        private string Number;

        public Telefone(string number)
        {
            Number = number;
        }

        public string GetTelefone()
        {
            return Number;
        }
    }
}

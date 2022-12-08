namespace ProjetoEngenhariaDeSoftware.Domain.DomainObjects
{
    public record CNPJ
    {
        public string Value;

        public CNPJ(string value)
        {
            Value = value;
        }
    }
}

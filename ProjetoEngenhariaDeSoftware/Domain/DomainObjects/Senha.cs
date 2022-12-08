namespace ProjetoEngenhariaDeSoftware.Domain.DomainObjects
{
    public record Senha
    {
        public string Valor { get; set; }

        public Senha(string valor)
        {
            if(valor.Length < 8)
            {
                throw new Exception("A senha não pode ter menos que 8 caracteres");
            }

            Valor = valor;
        }
    }
}

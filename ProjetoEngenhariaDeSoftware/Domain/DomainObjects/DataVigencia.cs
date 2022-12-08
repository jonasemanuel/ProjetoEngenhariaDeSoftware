namespace ProjetoEngenhariaDeSoftware.Domain.DomainObjects
{
    public record DataVigencia
    {
        public DateTime Data { get; set; }

        public DataVigencia(DateTime data)
        {
            if(data < DateTime.Today)
            {
                throw new Exception("A data do contrato não pode ser uma data no passado");
            }

            Data = data;
        }
    }
}

namespace AppDomain.Entities
{
    public abstracts  class EntidadeDominio
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCriacao {get; set;} = DateTime.Now;       
        
    }
}
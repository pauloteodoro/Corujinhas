using System;

namespace AppDomain.Entities
{
    public abstract class EntidadeDominio
    {
        protected EntidadeDominio()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
using System;

namespace AppDomain.Entities
{
    public abstract class EntidadeDominio
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime DataCriacao { get; private set; } = DateTime.Now;

    }
}
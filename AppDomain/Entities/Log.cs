using System;

namespace AppDomain.Entities
{
    public class Log : EntidadeDominio
    {
        public string Mensagem { get; private set; }

        public DateTime DataVisualização { get; private set; }

    }
}
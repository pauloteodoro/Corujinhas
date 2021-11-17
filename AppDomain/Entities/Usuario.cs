using System.Collections.Generic;

namespace AppDomain.Entities
{
    public class Usuario : EntidadeDominio
    {
        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            this.Cpf = cpf;
            Status = true;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public bool Status { get; private set; }

        public ICollection<TipoUsuario> TiposUsuarios { get; set; }

        public void AlterarStatusUsuario()
        {
            Status = !Status;
        }

    }
}
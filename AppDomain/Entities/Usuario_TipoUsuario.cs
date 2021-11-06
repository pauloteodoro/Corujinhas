using System;

namespace AppDomain.Entities
{
    public class Usuario_TipoUsuario : EntidadeDominio
    {
        public Usuario_TipoUsuario(Usuario usuario, TipoUsuario tipoUsuario)
        {
            Usuario = usuario;
            TipoUsuario = tipoUsuario;
        }

        public Usuario Usuario { get; private set; }
        public TipoUsuario TipoUsuario { get; private set; }

        public bool Status { get; private set; }



    }
}
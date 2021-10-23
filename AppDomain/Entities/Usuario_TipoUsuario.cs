using System;

namespace AppDomain.Entities
{
    public class Usuario_TipoUsuario : EntidadeDominio
    {
        public Usuario_TipoUsuario(Guid usuarioID, Guid tipoUsuarioID)
        {
            UsuarioID = usuarioID;
            TipoUsuarioID = tipoUsuarioID;
        }

        public Guid UsuarioID { get; private set; }
        public Guid TipoUsuarioID { get; private set; }

        public bool Status { get; private set; }



    }
}
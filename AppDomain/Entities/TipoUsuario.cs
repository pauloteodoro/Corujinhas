using System.Collections.Generic;

namespace AppDomain.Entities
{
    public class TipoUsuario : EntidadeDominio
    {
        public TipoUsuario(string codigo, string nome, string descricao)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            StatusTipoUsuario = true;
        }

        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool StatusTipoUsuario { get; private set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
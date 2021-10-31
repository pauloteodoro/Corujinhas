using System.Collections.Generic;

namespace AppDomain.Entities
{
    public class CategoriaIngrediente : EntidadeDominio
    {
        public CategoriaIngrediente(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            StatusCategoria = true;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool StatusCategoria { get; private set; }

        public virtual ICollection<Ingrediente> Ingredientes { get; set; }

        public void AlterarStatusDescricao()
        {
            StatusCategoria = !StatusCategoria;
        }
    }
}
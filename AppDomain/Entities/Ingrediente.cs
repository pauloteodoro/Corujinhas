using System;

namespace AppDomain.Entities
{
    public class Ingrediente : EntidadeDominio
    {
        public Ingrediente(string nome)
        {
            Nome = nome;
            Status = true;
        }

        public string Nome { get; private set; }
        public bool Status { get; private set; }
        public CategoriaIngrediente CategoriaIngrediente { get; set; }

        public void AlterarStatusIngrediente()
        {
            Status = !Status;
        }

    }
}
using System;

namespace AppDomain.Entities
{
    public class Prato : EntidadeDominio
    {
        public Prato(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Ativo = true;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public bool Ativo { get; private set; }
        public Receita Receita { get; set; }

        public void AlterarStatusPrato()
        {
            Ativo = !Ativo;
        }
    }
}
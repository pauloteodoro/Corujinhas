using System;

namespace AppDomain.Entities
{
    public class Ingrediente_Receita : EntidadeDominio
    {
        public Ingrediente_Receita(Receita receita, Ingrediente ingrediente, int quantidade)
        {
            Receita = receita;
            Ingrediente = ingrediente;
            Quantidade = quantidade;
        }

        public Receita Receita { get; private set; }
        public Ingrediente Ingrediente { get; private set; }

        public int Quantidade { get; private set; }



    }
}
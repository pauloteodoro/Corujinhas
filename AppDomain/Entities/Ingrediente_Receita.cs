using System;

namespace AppDomain.Entities
{
    public class Ingrediente_Receita : EntidadeDominio
    {
        public Ingrediente_Receita(Guid receitaID, Guid ingredienteID, int quantidade)
        {
            ReceitaID = receitaID;
            IngredienteID = ingredienteID;
            Quantidade = quantidade;
        }

        public Guid ReceitaID { get; private set; }
        public Guid IngredienteID { get; private set; }

        public int Quantidade { get; private set; }



    }
}
using System.Collections.Generic;

namespace AppDomain.Entities
{
    public class Relatorio : EntidadeDominio
    {
        public Relatorio(int quantidadeIngrediente, List<Ingrediente> ingredientes)
        {
            QuantidadeIngrediente = quantidadeIngrediente;
            Ingredientes = ingredientes;
        }

        public int QuantidadeIngrediente { get; private set; }
        public List<Ingrediente> Ingredientes { get; private set; }

        // horas
    }
}
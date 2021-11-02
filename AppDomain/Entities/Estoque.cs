using System;

namespace AppDomain.Entities
{
    public class Estoque : EntidadeDominio
    {
        public Estoque(int quantidadeMaxima, int quantidadeMinima, int quantidadeAtual)
        {
            this.QuantidadeMaxima = quantidadeMaxima;
            this.QuantidadeMinima = quantidadeMinima;
            this.QuantidadeAtual = quantidadeAtual;

        }

        public Decimal QuantidadeMaxima { get; private set; }
        public Decimal QuantidadeMinima { get; private set; }
        public Decimal QuantidadeAtual { get; private set; }

        public Guid IngredienteID { get; set; }
        public virtual Ingrediente Ingrediente { get; set; }
        public Guid UnidadeMedidaID { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }


    }
}
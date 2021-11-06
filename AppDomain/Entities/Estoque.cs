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

        public Ingrediente Ingrediente { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }


    }
}
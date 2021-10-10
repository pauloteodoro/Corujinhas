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

        public int QuantidadeMaxima { get; private set; }
        public int QuantidadeMinima { get; private set; }
        public int QuantidadeAtual { get; private set; }
    }
}
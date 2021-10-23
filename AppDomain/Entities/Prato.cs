namespace AppDomain.Entities
{
    public class Prato : EntidadeDominio
    {
        public Prato(string nome, decimal preco, bool ativo, Receita receitas)
        {
            Nome = nome;
            Preco = preco;
            Ativo = ativo;
            Receitas = receitas;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public bool Ativo { get; private set; }
        public Receita Receitas { get; private set; }
    }
}
namespace AppDomain.Entities
{
    public class CategoriaIngrediente :EntidadeDominio
    {
        public CategoriaIngrediente(string nome, string descricao, bool statusCategoria)
        {
            Nome = nome;
            Descricao = descricao;
            StatusCategoria = statusCategoria;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool StatusCategoria { get; private set; }
    }
}
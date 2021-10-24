namespace AppDomain.Entities
{
    public class Ingrediente : EntidadeDominio
    {
        public Ingrediente(string nome, bool status)
        {
            Nome = nome;
            Status = status;
        }

        public string Nome { get; private set; }
        public bool Status { get; private set; }


    }
}
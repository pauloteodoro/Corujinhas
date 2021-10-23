namespace AppDomain.Entities
{
    public class Usuario : EntidadeDominio
    {
        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            this.cpf = cpf;
            Status = true;
        }

        public string Nome { get; private set; }
        public string cpf { get; private set; }
        public bool Status { get; private set; }


    }
}
namespace AppDomain.Entities
{
    public class UnidadeMedida : EntidadeDominio
    {
        public UnidadeMedida(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Status = true;
        }

        public string Codigo { get; private set; }
        public string Nome { get; private set; }

        public bool Status { get; private set; }


        public void AtivarStatus()
        {
            Status = true;
        }

        public void DesativarStatus()
        {
            Status = false;
        }

    }
}
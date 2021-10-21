namespace AppDomain.Entities
{
    public class Email
    {
        public int EmailId { get; private set; }
        public string Assunto { get; private set; }
        public string Descricao { get; private set; }
        public string Anexo { get; private set; }
        public string Destinatario { get; private set; }
        public string Remetente { get; private set; }

    }
}
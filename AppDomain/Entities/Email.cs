namespace AppDomain.Entities
{
    public class Email : EntidadeDominio
    {
        public Email(int emailId, string assunto, string descricao, string anexo, string destinatario)
        {
            EmailId = emailId;
            Assunto = assunto;
            Descricao = descricao;
            Anexo = anexo;
            Destinatario = destinatario;
        }

        public int EmailId { get; private set; }
        public string Assunto { get; private set; }
        public string Descricao { get; private set; }
        public string Anexo { get; private set; }
        public string Destinatario { get; private set; }
    }
}
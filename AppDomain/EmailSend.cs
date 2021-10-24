using System.Net.Mail;

namespace AppDomain
{
    public class EmailSend
    {
        public void EnviarEmail(string destinatario, string body)
        // public void EnviarEmail(string remetente, string destinatario, string cc, string bcc, string subject, string body)
        {
            MailMessage email = new MailMessage();
            email.From = new MailAddress("corujinhas_tetste@gmail.com");
            email.To.Add(new MailAddress(destinatario));


            // if (cc != "")
            // {
            //     email.CC.Add(new MailAddress(cc));
            // }

            // if (bcc != "")

            // {

            //     email.Bcc.Add(new MailAddress(bcc));

            // }

            // email.Subject = subject;

            email.Body = "teste";

            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;



            // SmtpClient smtp = new SmtpClient("exemplo.server.com");
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            client.Host = "smtp.gmail.com";
            System.Net.NetworkCredential basicauthenticationinfo = new System.Net.NetworkCredential("corujinhas.teste@gmail.com", "Co123456@");
            client.Port = int.Parse("587");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicauthenticationinfo;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;



            client.Send(email);

        }
    }
}
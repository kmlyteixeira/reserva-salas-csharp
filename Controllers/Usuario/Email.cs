using System.Net.Mail;
using System.IO;
using Newtonsoft.Json;

namespace reserva_salas_csharp.Controllers
{
    public class Email
    {
        public static void EnviarEmail(string email, string assunto, string mensagem)
        {
            string json = File.ReadAllText("../credentials.json");

            dynamic credentials = JsonConvert.DeserializeObject(json);

            string emailUsername = credentials.Email.Username;
            string emailPassword = credentials.Email.Password;

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress(emailUsername, "", System.Text.Encoding.UTF8);
                mail.Subject = assunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = mensagem;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(emailUsername, emailPassword);
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                client.Send(mail);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}
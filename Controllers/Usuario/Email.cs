using System.Net.Mail;
using System.IO;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Message = Google.Apis.Gmail.v1.Data.Message;

namespace reserva_salas_csharp.Controllers
{
    public class Email
    {

        public static void EnviarEmail(string email, string assunto, string mensagem)
        {
            string json = File.ReadAllText("client_secret_google.json");

            dynamic credentials = JsonConvert.DeserializeObject(json);

            string clienteId = credentials.installed.client_id;
            string clientSecret = credentials.installed.project_id;
            string[] scopes = { GmailService.Scope.GmailSend };

            UserCredential credential;

            using (var stream = new FileStream("client_secret_google.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)).Result;
            }

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Reserva de Salas"
            });


            string jsonCredentials = File.ReadAllText("credentials.json");
            dynamic credentialsEmail = JsonConvert.DeserializeObject(jsonCredentials);
            string emailSender = credentialsEmail.Email.Username;

            var emailMessage = CreateEmail(emailSender, email, assunto, mensagem);

            SendEmail(service, "me", emailMessage);
        }

        static Message CreateEmail(string sender, string recipient, string subject, string body)
        {
            var email = new MimeKit.MimeMessage();
            email.From.Add(new MimeKit.MailboxAddress("", sender));
            email.To.Add(new MimeKit.MailboxAddress("", recipient));
            email.Subject = subject;

            var bodyBuilder = new MimeKit.BodyBuilder();
            bodyBuilder.TextBody = body;

            email.Body = bodyBuilder.ToMessageBody();

            using (var memoryStream = new MemoryStream())
            {
                email.WriteTo(memoryStream);
                return new Message { Raw = Convert.ToBase64String(memoryStream.ToArray()) };
            }
        }

        static void SendEmail(GmailService service, string userId, Message email)
        {
            try 
            {
                service.Users.Messages.Send(email, userId).Execute();
            } catch (Google.GoogleApiException ex)
            {
                throw new Exception("Erro ao enviar email: " + ex.Message);
            }
        }
    }
}
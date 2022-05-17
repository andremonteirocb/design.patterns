using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace Fundamentos.Design.Patterns.Criacional.Builder
{
    public class EmailBuilder
    {
        public MailMessage Message { get; private set; }
        public SmtpClient Smtp { get; private set; }
        public EmailBuilder(string destinatario, string remetente, string assunto, string mensagem)
        {
            bool bValidaEmail = ValidaEnderecoEmail(destinatario);
            if (bValidaEmail == false) throw new Exception("Email do destinatário inválido:" + destinatario);

            Message = new MailMessage(remetente, destinatario, assunto, mensagem);
        }

        public void AddAnexos(ArrayList anexos)
        {
            foreach (string anexo in anexos)
            {
                Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                Message.Attachments.Add(anexado);
            }
        }

        public EmailBuilder AddSmtp(string host, int port)
        {
            Smtp = new SmtpClient(host, port);
            return this;
        }

        public EmailBuilder AddCredentials(string login, string senha)
        {
            Smtp.Credentials = new NetworkCredential(login, senha);
            return this;
        }

        public EmailBuilder UseEnabledSsl()
        {
            Smtp.EnableSsl = true;
            return this;
        }

        public EmailBuilder UseDefaultCredentials()
        {
            Smtp.UseDefaultCredentials = true;
            return this;
        }

        public bool Send()
        {
            Smtp.Send(Message);
            return true;
        }

        private static bool ValidaEnderecoEmail(string texto_validar)
        {
            try
            {
                var expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");
                return expressaoRegex.IsMatch(texto_validar) ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using Fundamentos.Design.Patterns.Comportamental.Visit.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.Visit
{
    public class NotificationVisitor : INotificationVisitor
    {
        public void Visit(SmsMessage message)
        {
            Console.WriteLine("Sms message!");
        }

        public void Visit(EmailMessage message)
        {
            Console.WriteLine("E-mail message!");
        }

        public void Visit(WhatsappMessage message)
        {
            Console.WriteLine("Whatsapp message!");
        }
    }
}
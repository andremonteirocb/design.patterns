namespace Fundamentos.Design.Patterns.Comportamental.Visit.Interfaces
{
    public interface INotificationVisitor
    {
        void Visit(SmsMessage message);
        void Visit(EmailMessage message);
        void Visit(WhatsappMessage message);
    }
}
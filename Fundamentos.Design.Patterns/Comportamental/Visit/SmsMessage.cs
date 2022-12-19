using Fundamentos.Design.Patterns.Comportamental.Visit.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.Visit
{
    public class SmsMessage : IMarketingMessage
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Content { get; private set; }

        public void Accept(INotificationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
namespace Fundamentos.Design.Patterns.Comportamental.Visit.Interfaces
{
    public interface IMarketingMessage
    {
        string From { get; }
        string To { get; }
        string Content { get; }
        void Accept(INotificationVisitor visitor);
    }
}
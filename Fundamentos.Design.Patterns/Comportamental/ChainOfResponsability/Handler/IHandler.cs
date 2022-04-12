namespace Fundamentos.Design.Patterns.Comportamental.ChainOfResponsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handle(object request);
    }
}

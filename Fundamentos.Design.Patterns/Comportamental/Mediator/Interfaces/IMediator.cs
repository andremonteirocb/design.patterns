namespace Fundamentos.Design.Patterns.Comportamental.Mediator.Interfaces
{
    public interface IMediator
    {
        void SendMessage(string message, UserBase user);
        void RegisterUser(UserBase user);
    }
}

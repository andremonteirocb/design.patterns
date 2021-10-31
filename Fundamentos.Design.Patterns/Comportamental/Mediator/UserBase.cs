using Fundamentos.Design.Patterns.Comportamental.Mediator.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.Mediator
{
    public abstract class UserBase
    {
        protected IMediator mediator;
        protected string name;
        protected UserBase(IMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}

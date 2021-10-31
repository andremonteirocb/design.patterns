using Fundamentos.Design.Patterns.Comportamental.Mediator.Interfaces;
using System;

namespace Fundamentos.Design.Patterns.Comportamental.Mediator
{
    public class User : UserBase
    {
        public User(IMediator mediator, string name) 
            : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} : enviada => {message}");
            mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} : recebida <= {message}");
        }
    }
}

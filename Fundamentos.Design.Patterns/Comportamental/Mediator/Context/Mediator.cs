using Fundamentos.Design.Patterns.Comportamental.Mediator.Interfaces;
using System.Collections.Generic;

namespace Fundamentos.Design.Patterns.Comportamental.Mediator.Context
{
    public class Mediator : IMediator
    {
        readonly List<UserBase> users = new List<UserBase>();
        public void RegisterUser(UserBase user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, UserBase user)
        {
            users.ForEach(u =>
            {
                if (u != user)
                    u.Receive(message);
            });
        }
    }
}

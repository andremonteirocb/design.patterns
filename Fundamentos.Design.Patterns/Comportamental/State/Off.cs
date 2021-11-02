using Fundamentos.Design.Patterns.Comportamental.State.Context;
using Fundamentos.Design.Patterns.Comportamental.State.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.State
{
    public class Off : IState
    {
        public void Handle(Machine context)
        {
            context.State = new On();
        }
    }
}

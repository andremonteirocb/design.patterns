using Fundamentos.Design.Patterns.Comportamental.State.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.State
{
    public class Off : IState
    {
        public void Handle(Context.Machine context)
        {
            context.State = new On();
        }
    }
}

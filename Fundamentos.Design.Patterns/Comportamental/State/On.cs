using Fundamentos.Design.Patterns.Comportamental.State.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.State
{
    public class On : IState
    {
        public void Handle(Context.Machine context)
        {
            context.State = new Standby();
        }
    }
}

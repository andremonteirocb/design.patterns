using Fundamentos.Design.Patterns.Comportamental.State.Context;

namespace Fundamentos.Design.Patterns.Comportamental.State.Interfaces
{
    public interface IState
    {
        void Handle(Context.Machine context);
    }
}

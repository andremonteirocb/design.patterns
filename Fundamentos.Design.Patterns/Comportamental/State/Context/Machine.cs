using Fundamentos.Design.Patterns.Comportamental.State.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.State.Context
{
    public class Machine
    {
        private IState state;
        public Machine(IState newstate)
        {
            state = newstate;
        }

        public void Request()
        {
            state.Handle(this);
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}

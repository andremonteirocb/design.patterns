﻿using Fundamentos.Design.Patterns.Comportamental.State.Context;
using Fundamentos.Design.Patterns.Comportamental.State.Interfaces;

namespace Fundamentos.Design.Patterns.Comportamental.State
{
    public class Standby : IState
    {
        public void Handle(Machine context)
        {
            context.State = new Off();
        }
    }
}

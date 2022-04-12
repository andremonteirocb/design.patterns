using Fundamentos.Design.Patterns.Comportamental.TemplateMethod.Models;
using System.Collections.Generic;

namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod
{
    public abstract class AbstractRelatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}

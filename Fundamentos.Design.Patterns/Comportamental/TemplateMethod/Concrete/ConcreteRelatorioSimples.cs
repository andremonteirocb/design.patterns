using Fundamentos.Design.Patterns.Comportamental.TemplateMethod.Models;
using System;
using System.Collections.Generic;

namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod
{
    public class ConcreteRelatorioSimples : AbstractRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}

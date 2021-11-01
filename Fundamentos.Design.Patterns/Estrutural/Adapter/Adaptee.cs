using Fundamentos.Design.Patterns.Estrutural.Adapter.Domain;
using System.Collections.Generic;
using System;

namespace Fundamentos.Design.Patterns.Estrutural.Adapter
{
    public class Adaptee
    {
        public void Matricular(List<Aluno> listaAlunos)
        {
            listaAlunos.ForEach(aluno =>
                Console.WriteLine($"Aluno {aluno.Nome} " + $"- Valor da mensalidade R$ {aluno.Mensalidade}"));
        }
    }
}

using Fundamentos.Design.Patterns.Estrutural.Adapter.Domain;
using System.Collections.Generic;

namespace Fundamentos.Design.Patterns.Estrutural.Adapter.Manager
{
    public interface ITarget
    {
        List<Aluno> Converter(string[,] alunosArray);
    }
}

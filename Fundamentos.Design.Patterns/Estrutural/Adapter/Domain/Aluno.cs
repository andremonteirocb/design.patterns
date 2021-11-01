namespace Fundamentos.Design.Patterns.Estrutural.Adapter.Domain
{
    public class Aluno
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Curso { get; private set; }
        public decimal Mensalidade { get; private set; }
        public Aluno(int id, string nome, string curso, decimal mensalidade)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            Mensalidade = mensalidade;
        }
    }
}

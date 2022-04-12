namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod.Models
{
    public class Conta
    {
        public Conta(string nome, string numero, string agencia, double saldo)
        {
            Nome = nome;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public double Saldo { get; set; }
    }
}

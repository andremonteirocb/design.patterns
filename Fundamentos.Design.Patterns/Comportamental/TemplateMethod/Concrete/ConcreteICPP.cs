namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod
{
    public class ConcreteICPP : AbstractTemplate
    {
        protected override bool DeveUsarMaximaTaxacao(double valor)
        {
            return valor >= 500;
        }
        protected override double MaximaTaxacao(double valor)
        {
            return valor;
        }
        protected override double MinimaTaxacao(double valor)
        {
            return valor * 0.05;
        }
    }
}

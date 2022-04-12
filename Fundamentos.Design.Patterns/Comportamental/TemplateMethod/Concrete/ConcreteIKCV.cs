namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod
{
    public class ConcreteIKCV : AbstractTemplate
    {
        protected override bool DeveUsarMaximaTaxacao(double valor)
        {
            return valor > 500;
        }
        protected override double MaximaTaxacao(double valor)
        {
            return valor * 0.10;
        }
        protected override double MinimaTaxacao(double valor)
        {
            return valor * 0.06;
        }
    }
}

namespace Fundamentos.Design.Patterns.Comportamental.TemplateMethod
{
    public abstract class AbstractTemplate
    {
        public double Calcula(double valor)
        {
            if (DeveUsarMaximaTaxacao(valor))
            {
                return MaximaTaxacao(valor);
            }
            else
            {
                return MinimaTaxacao(valor);
            }
        }

        protected abstract bool DeveUsarMaximaTaxacao(double valor);
        protected abstract double MaximaTaxacao(double valor);
        protected abstract double MinimaTaxacao(double valor);
    }
}

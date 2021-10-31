using Design.Patterns.Strategy.Strategy;

namespace Design.Patterns.Strategy.Context
{
    public class Frete
    {
        private IFrete _frete;
        public Frete(IFrete frete)
        {
            _frete = frete;
        }

        public decimal CalcularValorDoFrete(decimal peso)
        {
            return _frete.Calcular(peso);
        }
    }
}

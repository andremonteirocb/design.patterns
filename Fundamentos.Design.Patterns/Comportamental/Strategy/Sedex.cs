using Design.Patterns.Strategy.Strategy;

namespace Design.Patterns.Strategy
{
    public class DHL : IFrete
    {
        public decimal Calcular(decimal peso)
        {
            return peso * 3.0M;
        }
    }
}

using Design.Patterns.Strategy.Strategy;

namespace Design.Patterns.Strategy
{
    public class Dhl : IFrete
    {
        public decimal Calcular(decimal peso)
        {
            return peso * 2.0M;
        }
    }
}

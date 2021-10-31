using Design.Patterns.Strategy;
using Design.Patterns.Strategy.Context;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void Strategy_CalcularValorFreteDhl_RetornarSucesso()
        {
            //Arrange
            var dhl = new Dhl();
            var frete = new Frete(dhl);

            //Act
            var result = frete.CalcularValorDoFrete(10);

            //Assert
            Assert.Equal(20.0M, result);
        }

        [Fact]
        public void Strategy_CalcularValorFreteDhl_RetornarFalha()
        {
            //Arrange
            var dhl = new Dhl();
            var frete = new Frete(dhl);

            //Act
            var result = frete.CalcularValorDoFrete(10);

            //Assert
            Assert.Equal(20.0M, result);
        }
    }
}

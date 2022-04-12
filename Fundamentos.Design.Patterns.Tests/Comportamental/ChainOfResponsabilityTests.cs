using Fundamentos.Design.Patterns.Comportamental.ChainOfResponsability;
using System;
using Xunit;

namespace Fundamentos.Design.Patterns.Tests.Comportamental
{
    public class ChainOfResponsabilityTests
    {
        [Fact]
        public void ChainOfResponsability_CalcularResponsabilidade_RetornarSucesso()
        {
            //Arrange
            var d1 = new DescontoISSHandler();
            var d2 = new DescontoFGTSlHandler();
            var d3 = new DescontoICMSHandler();

            //Act
            d1.SetNext(d2).SetNext(d3);
            var result = d1.Handle("FGTS");
            
            //Assert
            Assert.NotEmpty(result);
        }
    }
}

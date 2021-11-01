using Design.Patterns.Facade;
using Design.Patterns.Facade.Domain;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class FacadeTests
    {
        [Fact]
        public void Facade_EfetuarProcessoDePagamento_RetornarSucesso()
        {
            //Arrange
            var transacao = new Transacao();
            var impressao = new Impressao();
            var facade = new Facade(transacao, impressao);

            //Act
            var result = facade.Pagar();

            //Assert
            Assert.True(result);
        }
    }
}

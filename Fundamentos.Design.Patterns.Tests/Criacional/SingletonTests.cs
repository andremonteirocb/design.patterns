using Design.Patterns.Singleton;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_ValidarIgualdadeDeObjetos_RetornarSucesso()
        {
            //Arrange
            var conexao1 = ConexaoSingleton.GetInstance();
            var conexao2 = ConexaoSingleton.GetInstance();

            //Act
            var result = conexao1 == conexao2;

            //Assert
            Assert.True(result);
        }
    }
}

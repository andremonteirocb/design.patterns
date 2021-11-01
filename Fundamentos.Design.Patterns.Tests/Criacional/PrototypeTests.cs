using Fundamentos.Design.Patterns.Criacional.Prototype;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class PrototypeTests
    {
        [Fact]
        public void Prototype_CriarObjetosClonaveis_RetornarSucesso()
        {
            //Arrange
            var pessoa = new Pessoa("User Test");
            var pessoa2 = (Pessoa)pessoa.Clone();
            
            //Act
            pessoa2.ChangeName("User Test Clonado");

            //Assert
            Assert.Equal("User Test", pessoa.Name);
            Assert.Equal("User Test Clonado", pessoa2.Name);
        }

        [Fact]
        public void Prototype_CriarObjetosClonaveis_RetornarFalha()
        {
            //Arrange
            var pessoa = new Pessoa("User Test");
            var pessoa2 = pessoa;

            //Act
            pessoa2.ChangeName("User Test Clonado");

            //Assert
            Assert.Equal("User Test Clonado", pessoa.Name);
            Assert.Equal("User Test Clonado", pessoa2.Name);
        }
    }
}

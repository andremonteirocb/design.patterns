using Fundamentos.Design.Patterns.Criacional.Builder;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class BuilderTests
    {
        [Fact]
        public void Builder_EnviarEmail_RetornarSucesso()
        {
            //Arrange
            var builder = new EmailBuilder("emaildestino@gmail.com", "emailremetente@gmail.com", "assunto", "mensagem")
                .AddSmtp("smtp.gmail.com", 587)
                .AddCredentials("login", "senha")
                .UseDefaultCredentials()
                .UseEnabledSsl();

            //Act
            var result = builder.Send(); 

            //Assert
            Assert.True(result);
        }
    }
}

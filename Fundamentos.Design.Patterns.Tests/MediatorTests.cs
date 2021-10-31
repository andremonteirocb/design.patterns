using Fundamentos.Design.Patterns.Comportamental.Mediator;
using Fundamentos.Design.Patterns.Comportamental.Mediator.Context;
using System;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class MediatorTests
    {
        [Fact]
        public void Mediator_CalcularValorFreteDhl_RetornarSucesso()
        {
            //Arrange
            var mediator = new Mediator();
            var user = new User(mediator, Guid.NewGuid().ToString());
            var user2 = new User(mediator, Guid.NewGuid().ToString());
            var user3 = new User(mediator, Guid.NewGuid().ToString());

            mediator.RegisterUser(user);
            mediator.RegisterUser(user2);
            mediator.RegisterUser(user3);

            //Act
            user.Send("Testando");

            //Assert
            Assert.True(true);
        }
    }
}

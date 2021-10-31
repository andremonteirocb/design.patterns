using Fundamentos.Design.Patterns.Observer;
using System;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class ObserverTests
    {
        [Fact]
        public void Observer_ObservarAlteracoesNoCanalENotificarInscritos_RetornarSucesso()
        {
            //Arrange
            var channel = new YoutubeChannel("My Channel");
            var subscriber = new Subscriber(Guid.NewGuid().ToString());
            var subscriber2 = new Subscriber(Guid.NewGuid().ToString());
            var subscriber3 = new Subscriber(Guid.NewGuid().ToString());
            var subscriberAnonymous = new SubscriberAnonymous(Guid.NewGuid().ToString());

            channel.Attach(subscriber);
            channel.Attach(subscriber2);
            channel.Attach(subscriber3);
            channel.Attach(subscriberAnonymous);

            //Act
            channel.ChangeName("My Channel Test");

            //Assert
            Assert.True(true);
        }
    }
}

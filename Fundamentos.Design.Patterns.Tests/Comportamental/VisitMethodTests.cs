using Fundamentos.Design.Patterns.Comportamental.TemplateMethod;
using Fundamentos.Design.Patterns.Comportamental.TemplateMethod.Models;
using Fundamentos.Design.Patterns.Comportamental.Visit;
using Fundamentos.Design.Patterns.Comportamental.Visit.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace Fundamentos.Design.Patterns.Tests.Comportamental
{
    public class VisitMethodTests
    {
        [Fact]
        public void VisitMethod_RetornarSucesso()
        {
            //Arrange
            var visitor = new NotificationVisitor();
            var messages = new List<IMarketingMessage>
            {
                new EmailMessage(),
                new SmsMessage(),
                new WhatsappMessage()
            };

            //Act
            messages.ForEach(message => 
                message.Accept(visitor));

            //Assert
            Assert.True(true);
        }
    }
}

using Fundamentos.Design.Patterns.Comportamental.State;
using Fundamentos.Design.Patterns.Comportamental.State.Context;
using Xunit;
using Xunit.Abstractions;

namespace Desing.Patterns.Tests
{
    public class StateTests
    {
        private readonly ITestOutputHelper _output;
        public StateTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void State__RetornarSucesso()
        {
            //Arrange
            var machine = new Machine(new On());
            _output.WriteLine(machine.State.ToString());

            //Act
            machine.Request();
            _output.WriteLine(machine.State.ToString());

            machine.Request();
            _output.WriteLine(machine.State.ToString());

            //Assert
            Assert.Equal("Fundamentos.Design.Patterns.Comportamental.State.Off", machine.State.ToString());
        }
    }
}

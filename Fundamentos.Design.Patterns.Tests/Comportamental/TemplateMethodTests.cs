using Fundamentos.Design.Patterns.Comportamental.TemplateMethod;
using Fundamentos.Design.Patterns.Comportamental.TemplateMethod.Models;
using System.Collections.Generic;
using Xunit;

namespace Fundamentos.Design.Patterns.Tests.Comportamental
{
    public class TemplateMethodTests
    {
        [Fact]
        public void TemplateMethod_CalcularImposto_RetornarSucesso()
        {
            //Arrange
            var IKCV = new ConcreteIKCV();
            var ICPP = new ConcreteICPP();

            //Act
            var resultIKCV = IKCV.Calcula(10);
            var resultICPP = ICPP.Calcula(10);

            //Assert
            Assert.Equal(0.6, resultIKCV);
            Assert.Equal(0.5, resultICPP);
        }

        [Fact]
        public void TemplateMethod_GerarRelatorio_RetornarSucesso()
        {
            //Arrange
            var SIMPLES = new ConcreteRelatorioSimples();
            var COMPLEXO = new ConcreteRelatorioComplexo();
            var CONTAS = new List<Conta>
            {
                new Conta("Banco do Brasil", "1231", "12312", 4321),
                new Conta("Santander", "4323", "4235", 36432),
                new Conta("Nubank", "5435", "5446", 5342),
                new Conta("Inter", "2432", "8866", 1231),
            };

            //Act
            SIMPLES.Imprime(CONTAS);
            COMPLEXO.Imprime(CONTAS);

            //Assert
            Assert.True(true);
        }
    }
}

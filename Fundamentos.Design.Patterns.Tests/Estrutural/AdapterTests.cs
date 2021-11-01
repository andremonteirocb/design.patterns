using Fundamentos.Design.Patterns.Estrutural.Adapter;
using Fundamentos.Design.Patterns.Estrutural.Adapter.Domain;
using System.Collections.Generic;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class AdapterTests
    {
        [Fact]
        public void Adapter_EfetuarConversaoListaStringParaListaDeAlunos_RetornarSucesso()
        {
            //Arrange
            var sistemaMensalidades = new Adaptee();
            var adapter = new Adapter();
            var arrayAlunos = new string[5, 4]
            {
                { "101", "Maria", "Artes", "1100" },
                { "102", "João", "Matemática", "1200" },
                { "103", "Pedro", "Desenho", "1300" },
                { "104", "Caio", "Engenharia", "1400" },
                { "105", "Janaína", "Estética", "1500" },
            };
            
            //Act
            var result = adapter.Converter(arrayAlunos);
            sistemaMensalidades.Matricular(result);

            //Assert
            Assert.IsType<List<Aluno>>(result);
        }
    }
}

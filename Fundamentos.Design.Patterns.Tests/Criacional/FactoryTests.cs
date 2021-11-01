using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.ValueObj;
using Design.Patterns.Factory.Manager.Processors;
using System;
using Xunit;

namespace Desing.Patterns.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void Factory_ValidarPagamentoCredito_RetornarSucesso()
        {
            //Arrange
            var creditCardTransactionProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);
            var creditCardTransaction = new CreditCardTransaction(1000, "Joe Satriani", "222", "1111222233334444");

            //Act
            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            //Assert
            Assert.True(creditCardTransactionInfo.Amount > 0);
            Assert.Equal(creditCardTransactionInfo.CreateDate.Date, DateTime.Now.Date);
            Assert.True(creditCardTransactionInfo.TransactionStatusType == TransactionStatusType.Authorized);
        }

        [Fact]
        public void Factory_ValidarPagamentoCredito_RetornarFalha()
        {
            //Arrange
            var creditCardTransactionProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);
            var creditCardTransaction = new CreditCardTransaction(15000, "Joe Satriani", "222", "1111222233334444");

            //Act
            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            //Assert
            Assert.True(creditCardTransactionInfo.Amount > 0);
            Assert.Equal(creditCardTransactionInfo.CreateDate.Date, DateTime.Now.Date);
            Assert.True(creditCardTransactionInfo.TransactionStatusType == TransactionStatusType.Unauthorized);
        }

        [Fact]
        public void Factory_ValidarPagamentoPix_RetornarSucesso()
        {
            //Arrange
            var pixTransactionProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Pix);
            var pixTransaction = new PixTransaction(1000, "11122233344");

            //Act
            var pixTransactionInfo = pixTransactionProcessor.Authorize(pixTransaction);

            //Assert
            Assert.True(pixTransactionInfo.Amount > 0);
            Assert.Equal(pixTransactionInfo.CreateDate.Date, DateTime.Now.Date);
            Assert.True(pixTransactionInfo.TransactionStatusType == TransactionStatusType.Authorized);
        }

        [Fact]
        public void Factory_ValidarPagamentoPix_RetornarFalha()
        {
            //Arrange
            var pixTransactionProcessor = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Pix);
            var pixTransaction = new PixTransaction(2500, "11122233344");

            //Act
            var pixTransactionInfo = pixTransactionProcessor.Authorize(pixTransaction);

            //Assert
            Assert.True(pixTransactionInfo.Amount > 0);
            Assert.Equal(pixTransactionInfo.CreateDate.Date, DateTime.Now.Date);
            Assert.True(pixTransactionInfo.TransactionStatusType == TransactionStatusType.Unauthorized);
        }
    }
}

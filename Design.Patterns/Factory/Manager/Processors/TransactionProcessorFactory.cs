using Design.Patterns.Factory.Domain.ValueObj;
using Design.Patterns.Factory.Manager.Processors.Interfaces;
using System;

namespace Design.Patterns.Factory.Manager.Processors
{
    public static class TransactionProcessorFactory
    {
        public static ITransactionProcessor CreateTransactionProcessor(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.CreditCard: return new CrediCardTransactionProcessor();
                case TransactionType.Debit: return new DebitTransactionProcessor();
                case TransactionType.PaymentSlip: return new PaymentSlipTransactionProcessor();
                case TransactionType.Pix: return new PixTransactionProcessor();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
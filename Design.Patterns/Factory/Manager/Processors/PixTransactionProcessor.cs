using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Manager.Processors.Base;
using Design.Patterns.Factory.Manager.Processors.Interfaces;

namespace Design.Patterns.Factory.Manager.Processors
{
    public class PixTransactionProcessor : ProcessorBase<PixTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var pixTransaction = base.ValidateTransactionType(transaction);
            return ProcessAuthorization(pixTransaction);
        }

        private static TransactionInfo ProcessAuthorization(PixTransaction pixTransaction)
        {
            pixTransaction.SetStatusInProgress();

            BusinessSimulation(ref pixTransaction);

            return new TransactionInfo(
                pixTransaction.TransactionKey,
                pixTransaction.CreateDate,
                pixTransaction.Amount,
                pixTransaction.TransactionStatusType
             );
        }

        private static void BusinessSimulation(ref PixTransaction pixTransaction)
        {
            if (pixTransaction.Amount >= 1 && pixTransaction.Amount <= 2000)
            {
                pixTransaction.SetStatusAuthorized();
                return;
            }

            pixTransaction.SetStatusUnauthorized();
        }
    }
}
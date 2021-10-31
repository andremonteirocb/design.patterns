using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Manager.Processors.Base;
using Design.Patterns.Factory.Manager.Processors.Interfaces;

namespace Design.Patterns.Factory.Manager.Processors
{
    public class DebitTransactionProcessor : ProcessorBase<DebitTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var debitTransaction = base.ValidateTransactionType(transaction);
            return ProcessAuthorization(debitTransaction);
        }

        private static TransactionInfo ProcessAuthorization(DebitTransaction debitTransaction)
        {
            debitTransaction.SetStatusInProgress();

            BusinessSimulation(ref debitTransaction);

            return new TransactionInfo(
                debitTransaction.TransactionKey,
                debitTransaction.CreateDate,
                debitTransaction.Amount,
                debitTransaction.TransactionStatusType
             );
        }

        private static void BusinessSimulation(ref DebitTransaction debitTransaction)
        {
            if (debitTransaction.Amount >= 1 && debitTransaction.Amount <= 5000)
            {
                debitTransaction.SetStatusAuthorized();
                return;
            }

            debitTransaction.SetStatusUnauthorized();
        }
    }
}
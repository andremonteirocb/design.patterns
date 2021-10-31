using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Manager.Processors.Base;
using Design.Patterns.Factory.Manager.Processors.Interfaces;

namespace Design.Patterns.Factory.Manager.Processors
{
    public class CrediCardTransactionProcessor : ProcessorBase<CreditCardTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var crediCardTransaction = base.ValidateTransactionType(transaction);
            return ProcessAuthorization(crediCardTransaction);
        }

        private static TransactionInfo ProcessAuthorization(CreditCardTransaction crediCardTransaction)
        {
            crediCardTransaction.SetStatusInProgress();

            BusinessSimulation(ref crediCardTransaction);

            return new TransactionInfo(
                crediCardTransaction.TransactionKey,
                crediCardTransaction.CreateDate,
                crediCardTransaction.Amount,
                crediCardTransaction.TransactionStatusType
             );
        }

        private static void BusinessSimulation(ref CreditCardTransaction crediCardTransaction)
        {
            if (crediCardTransaction.Amount >= 10 && crediCardTransaction.Amount <= 12000)
            {
                crediCardTransaction.SetStatusAuthorized();
                return;
            }

            crediCardTransaction.SetStatusUnauthorized();
        }
    }
}
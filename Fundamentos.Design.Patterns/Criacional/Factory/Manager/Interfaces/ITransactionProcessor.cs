using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.Base;

namespace Design.Patterns.Factory.Manager.Processors.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionInfo Authorize(TransactionBase transaction);
    }
}
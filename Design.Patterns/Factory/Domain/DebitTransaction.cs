using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Domain.ValueObj;

namespace Design.Patterns.Factory.Domain
{
    public sealed class DebitTransaction : TransactionBase
    {
        public string BankName { get; private set; }

        public DebitTransaction(double amount, string bankName) 
            : base(TransactionType.Debit, amount)
        {
            BankName = bankName;
        }
    }
}
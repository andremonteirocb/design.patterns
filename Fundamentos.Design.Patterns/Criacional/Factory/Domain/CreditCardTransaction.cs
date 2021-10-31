using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Domain.ValueObj;

namespace Design.Patterns.Factory.Domain
{
    public sealed class CreditCardTransaction : TransactionBase
    {
        public string HolderName { get; private set; }
        public string SecurityCode { get; private set; }
        public string CardNumber { get; private set; }

        public CreditCardTransaction(double amount, string holderName, string securityCode, string cardNumber)
            : base(TransactionType.CreditCard, amount)
        {
            HolderName = holderName;
            SecurityCode = securityCode;
            CardNumber = cardNumber;
        }
    }
}
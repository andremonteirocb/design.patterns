using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Domain.ValueObj;

namespace Design.Patterns.Factory.Domain
{
    public class PixTransaction : TransactionBase
    {
        public string Key { get; private set; }

        public PixTransaction(double amount, string key)
            : base(TransactionType.Pix, amount)
        {
            Key = key;
        }
    }
}

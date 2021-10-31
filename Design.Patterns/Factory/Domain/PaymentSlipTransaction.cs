using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Domain.ValueObj;
using System;

namespace Design.Patterns.Factory.Domain
{
    public sealed class PaymentSlipTransaction : TransactionBase
    {
        public string DocumentNumber { get; private set; }
        public string BarCode { get; private set; }
        public DateTime DueDate { get; private set; }

        public PaymentSlipTransaction(double amount, string documentNumber, string barCode, DateTime dueDate)
            : base(TransactionType.PaymentSlip, amount)
        {
            DocumentNumber = documentNumber;
            BarCode = barCode;
            DueDate = dueDate;
        }
    }
}
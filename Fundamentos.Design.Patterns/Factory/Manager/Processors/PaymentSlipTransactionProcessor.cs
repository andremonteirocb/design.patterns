﻿using Design.Patterns.Factory.Domain;
using Design.Patterns.Factory.Domain.Base;
using Design.Patterns.Factory.Manager.Processors.Base;
using Design.Patterns.Factory.Manager.Processors.Interfaces;
using System;

namespace Design.Patterns.Factory.Manager.Processors
{
    public class PaymentSlipTransactionProcessor : ProcessorBase<PaymentSlipTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var paymentSlipTransaction = base.ValidateTransactionType(transaction);
            return ProcessAuthorization(paymentSlipTransaction);
        }

        private static TransactionInfo ProcessAuthorization(PaymentSlipTransaction paymentSlipTransaction)
        {
            paymentSlipTransaction.SetStatusInProgress();

            BusinessSimulation(ref paymentSlipTransaction);

            return new TransactionInfo(
                paymentSlipTransaction.TransactionKey,
                paymentSlipTransaction.CreateDate, 
                paymentSlipTransaction.Amount,
                paymentSlipTransaction.TransactionStatusType
             );
        }

        private static void BusinessSimulation(ref PaymentSlipTransaction paymentSlipTransaction)
        {
            if (paymentSlipTransaction.Amount >= 100 && paymentSlipTransaction.Amount <= 20000 && paymentSlipTransaction.DueDate.Date >= DateTime.UtcNow.Date)
            {
                paymentSlipTransaction.SetStatusAuthorized();
                return;
            }

            paymentSlipTransaction.SetStatusUnauthorized();
        }
    }
}
namespace Design.Patterns.Factory.Domain.ValueObj
{
    public enum TransactionType
    {
        /// <summary>
        /// Cartão de crédito
        /// </summary>
        CreditCard = 0,

        /// <summary>
        /// Débito
        /// </summary>
        Debit = 1,

        /// <summary>
        /// Boleto
        /// </summary>
        PaymentSlip = 2,

        /// <summary>
        /// Pix
        /// </summary>
        Pix = 3
    }
}
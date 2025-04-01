namespace Ordering.Domain.ValueObjects
{
    public record Payment
    {
        public string? CardName { get; } = default!;
        public string CardNumber { get; } = default!;
        public string Expiration { get; } = default!;
        public string CVV { get; } = default!;
        public int PaymentMethod { get; } = default!;
        protected Payment()
        {

        }

        private Payment(string cardName, string cardNumber, string expiration, string ccv, int paymentMethod)
        {
            CardName = cardName;
            CardNumber = cardNumber;
            Expiration = expiration;
            CVV = ccv;
            PaymentMethod = paymentMethod;
        }

        public static Payment Of(string cardName, string cardNumber, string expiration, string ccv, int paymentMethod)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(cardNumber);
            ArgumentException.ThrowIfNullOrWhiteSpace(cardName);
            ArgumentException.ThrowIfNullOrWhiteSpace(ccv);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(ccv.Length, 3);

            return new Payment(cardName, cardNumber, expiration, ccv, paymentMethod);
        }
    }
}

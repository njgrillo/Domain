namespace Memorabilia.Domain.Constants;

public sealed class StripePaymentModes : DomainItemConstants
{
    public static readonly StripePaymentModes Payment = new(1, "payment");
    public static readonly StripePaymentModes Subscription = new(2, "subscription");

    public static readonly StripePaymentModes[] All =
    [
        Payment,
        Subscription
    ];

    private StripePaymentModes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }
}

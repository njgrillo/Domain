namespace Memorabilia.Domain.Constants;

public sealed class StripePaymentStatusTypes : DomainItemConstants
{
    public static readonly StripePaymentStatusTypes Canceled = new(1, "Canceled");
    public static readonly StripePaymentStatusTypes Completed = new(2, "Completed");
    public static readonly StripePaymentStatusTypes Pending = new(3, "Pending");

    public static readonly StripePaymentStatusTypes[] All =
    [
        Canceled,
        Completed,
        Pending
    ];

    private StripePaymentStatusTypes(int id, string name)
        : base(id, name) { }

    public static StripePaymentStatusTypes Find(int id)
        => All.SingleOrDefault(stripePaymentStatusType => stripePaymentStatusType.Id == id);
}

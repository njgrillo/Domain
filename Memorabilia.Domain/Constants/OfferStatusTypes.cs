namespace Memorabilia.Domain.Constants;

public sealed class OfferStatusTypes : DomainItemConstants
{
    public static readonly OfferStatusTypes Accepted = new(1, "Accepted");
    public static readonly OfferStatusTypes Canceled = new(6, "Canceled");
    public static readonly OfferStatusTypes Countered = new(2, "Countered");
    public static readonly OfferStatusTypes Expired = new(3, "Expired");
    public static readonly OfferStatusTypes Pending = new(4, "Pending");
    public static readonly OfferStatusTypes Rejected = new(5, "Rejected");

    public static readonly OfferStatusTypes[] All =
    [
        Accepted,
        Canceled,
        Countered,
        Expired,
        Pending,
        Rejected
    ];

    public static readonly OfferStatusTypes[] Completed =
    [
        Accepted,
        Canceled,
        Countered,
        Expired,
        Rejected
    ];

    public static readonly OfferStatusTypes[] Open =
    [
        Pending
    ];

    private OfferStatusTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static OfferStatusTypes Find(int id)
        => All.SingleOrDefault(offerStatusType => offerStatusType.Id == id);

    public static bool IsCompleted(int offerStatusTypeId)
        => Completed.Contains(Find(offerStatusTypeId));

    public static bool IsOpen(int offerStatusTypeId)
        => Open.Contains(Find(offerStatusTypeId));
}

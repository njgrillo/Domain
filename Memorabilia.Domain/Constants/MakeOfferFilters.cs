namespace Memorabilia.Domain.Constants;

public sealed class MakeOfferFilters : Filters<MakeOfferFilters>
{
    public static readonly MakeOfferFilters None = new("None");
    public static readonly MakeOfferFilters MakeOffer = new("Is Make Offer");
    public static readonly MakeOfferFilters NotMakeOffer = new("Is Not Make Offer");

    private MakeOfferFilters(string name)
        : base(name) { }

    public static readonly MakeOfferFilters[] All =
    [
        None,
        MakeOffer,
        NotMakeOffer
    ];

    public static readonly MakeOfferFilters[] FilterItems =
    [
        MakeOffer,
        NotMakeOffer
    ];
}

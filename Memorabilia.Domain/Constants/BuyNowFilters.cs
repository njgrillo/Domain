namespace Memorabilia.Domain.Constants;

public sealed class BuyNowFilters : Filters<BuyNowFilters>
{
    public static readonly BuyNowFilters None = new("None");
    public static readonly BuyNowFilters BuyNow = new("Is Buy Now");
    public static readonly BuyNowFilters IsNotBuyNow = new("Is Not Buy Now");

    private BuyNowFilters(string name)
        : base(name) { }

    public static readonly BuyNowFilters[] All =
    [
        None,
        BuyNow,
        IsNotBuyNow
    ];

    public static readonly BuyNowFilters[] FilterItems =
    [
        BuyNow,
        IsNotBuyNow
    ];
}

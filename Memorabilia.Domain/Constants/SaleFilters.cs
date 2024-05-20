namespace Memorabilia.Domain.Constants;

public sealed class SaleFilters : Filters<SaleFilters>
{
    public static readonly SaleFilters None = new("None");
    public static readonly SaleFilters ForSale = new("For Sale");
    public static readonly SaleFilters NotForSale = new("Not For Sale");

    private SaleFilters(string name)
        : base(name) { }

    public static readonly SaleFilters[] All =
    [
        None,
        ForSale,
        NotForSale
    ];

    public static readonly SaleFilters[] FilterItems =
    [
        ForSale,
        NotForSale
    ];
}

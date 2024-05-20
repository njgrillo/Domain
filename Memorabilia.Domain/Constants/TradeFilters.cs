namespace Memorabilia.Domain.Constants;

public sealed class TradeFilters : Filters<TradeFilters>
{
    public static readonly TradeFilters None = new("None");
    public static readonly TradeFilters ForTrade = new("For Trade");
    public static readonly TradeFilters NotForTrade = new("Not For Trade");

    private TradeFilters(string name)
        : base(name) { }

    public static readonly TradeFilters[] All =
    [
        None,
        ForTrade,
        NotForTrade
    ];

    public static readonly TradeFilters[] FilterItems =
    [
        ForTrade,
        NotForTrade
    ];
}

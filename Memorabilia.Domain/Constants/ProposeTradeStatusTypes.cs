namespace Memorabilia.Domain.Constants;

public sealed class ProposeTradeStatusTypes : DomainItemConstants
{
    public static readonly ProposeTradeStatusTypes Accepted = new(1, "Accepted");
    public static readonly ProposeTradeStatusTypes Canceled = new(6, "Canceled");
    public static readonly ProposeTradeStatusTypes Countered = new(2, "Countered");
    public static readonly ProposeTradeStatusTypes Expired = new(3, "Expired");
    public static readonly ProposeTradeStatusTypes Pending = new(4, "Pending");
    public static readonly ProposeTradeStatusTypes Rejected = new(5, "Rejected");

    public static readonly ProposeTradeStatusTypes[] All =
    [
        Accepted,
        Canceled,
        Countered,
        Expired,
        Pending,
        Rejected
    ];

    public static readonly ProposeTradeStatusTypes[] Completed =
    [
        Accepted,
        Canceled,
        Countered,
        Expired,
        Rejected
    ];

    public static readonly ProposeTradeStatusTypes[] Open =
    [
        Pending
    ];

    private ProposeTradeStatusTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static ProposeTradeStatusTypes Find(int id)
        => All.SingleOrDefault(ProposeTradeStatusTypes => ProposeTradeStatusTypes.Id == id);

    public static bool IsCompleted(int ProposeTradeStatusTypesId)
        => Completed.Contains(Find(ProposeTradeStatusTypesId));

    public static bool IsOpen(int ProposeTradeStatusTypesId)
        => Open.Contains(Find(ProposeTradeStatusTypesId));
}

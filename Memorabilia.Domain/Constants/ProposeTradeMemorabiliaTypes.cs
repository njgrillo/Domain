namespace Memorabilia.Domain.Constants;

public sealed class ProposeTradeMemorabiliaTypes : DomainItemConstants
{
    public static readonly ProposeTradeMemorabiliaTypes Receive = new(1, "Receive");
    public static readonly ProposeTradeMemorabiliaTypes Send = new(2, "Send");

    public static readonly ProposeTradeMemorabiliaTypes[] All =
    [
        Receive,
        Send
    ];

    private ProposeTradeMemorabiliaTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static ProposeTradeMemorabiliaTypes Find(int id)
        => All.SingleOrDefault(proposeTradeMemorabiliaType => proposeTradeMemorabiliaType.Id == id);
}

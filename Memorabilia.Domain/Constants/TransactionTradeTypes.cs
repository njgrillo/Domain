namespace Memorabilia.Domain.Constants;

public sealed class TransactionTradeTypes : DomainItemConstants
{
    public static readonly TransactionTradeTypes Received = new(1, "Received");
    public static readonly TransactionTradeTypes Sent = new(2, "Sent");

    public static readonly TransactionTradeTypes[] All =
    [
        Received,
        Sent
    ];

    private TransactionTradeTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static TransactionTradeTypes Find(int id)
        => All.SingleOrDefault(transactionTradeType => transactionTradeType.Id == id);
}

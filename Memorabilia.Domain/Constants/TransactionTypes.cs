namespace Memorabilia.Domain.Constants;

public sealed class TransactionTypes : DomainItemConstants
{
    public static readonly TransactionTypes PartialTrade = new(3, "Partial Trade");
    public static readonly TransactionTypes Sale = new(1, "Sale");
    public static readonly TransactionTypes Trade = new(2, "Trade");    

    public static readonly TransactionTypes[] All =
    [
        PartialTrade,
        Sale, 
        Trade
    ];

    private TransactionTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static TransactionTypes Find(int id)
        => All.SingleOrDefault(transactionType => transactionType.Id == id);
}

namespace Memorabilia.Domain.Constants;

public sealed class PurchaseTypes : DomainItemConstants
{    
    public static readonly PurchaseTypes Amazon = new(2, "Amazon");
    public static readonly PurchaseTypes Ebay = new(1, "eBay");
    public static readonly PurchaseTypes Facebook = new(5, "Facebook");
    public static readonly PurchaseTypes Other = new(3, "Other");
    public static readonly PurchaseTypes Retail = new(4, "Retail Store");
    public static readonly PurchaseTypes Unknown = new(8, "Unknown");
    

    public static readonly PurchaseTypes[] All =
    [
        Amazon,
        Ebay,
        Facebook,
        Other,
        Retail,
        Unknown
    ];

    private PurchaseTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static PurchaseTypes Find(int id)
        => All.SingleOrDefault(PurchaseTypes => PurchaseTypes.Id == id);

    public static PurchaseTypes Find(string name)
        => All.SingleOrDefault(PurchaseTypes => PurchaseTypes.Name == name);
}

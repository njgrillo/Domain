namespace Memorabilia.Domain.Constants;

public sealed class AcquisitionTypes : DomainItemConstants
{
    public static readonly AcquisitionTypes Gift = new(7, "Gift");
    public static readonly AcquisitionTypes InPerson = new(3, "In Person", "IP");
    public static readonly AcquisitionTypes PartialTrade = new(13, "Partial Trade");
    public static readonly AcquisitionTypes PrivateSigning = new(1, "Private Signing");
    public static readonly AcquisitionTypes PublicSigning = new(2, "Public Signing");
    public static readonly AcquisitionTypes Purchase = new(6, "Purchase");
    public static readonly AcquisitionTypes ThroughTheMail = new(4, "Through the Mail", "TTM");
    public static readonly AcquisitionTypes Trade = new(5, "Trade");

    public static readonly AcquisitionTypes[] All =
    [
        Gift,
        InPerson,
        PartialTrade,
        PrivateSigning,
        PublicSigning,
        Purchase,
        ThroughTheMail,
        Trade            
    ];

    public static readonly AcquisitionTypes[] CostAcquisitionTypes =
    [
        InPerson,
        PrivateSigning,
        PublicSigning,
        Purchase,
        ThroughTheMail
    ];

    public static readonly AcquisitionTypes[] MemorabiliaAcquisitionTypes =
    [
        Gift,
        PartialTrade,
        Purchase,
        Trade
    ];

    private AcquisitionTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static AcquisitionTypes Find(int id)
        => All.SingleOrDefault(acquisitionType => acquisitionType.Id == id);

    public static AcquisitionTypes Find(string name)
        => All.SingleOrDefault(acquisitionType => acquisitionType.Name == name);
}

namespace Memorabilia.Domain.Constants;

public sealed class CerealTypes : DomainItemConstants
{
    public static readonly CerealTypes None = new(3, "None");
    public static readonly CerealTypes Other = new(2, "Other");
    public static readonly CerealTypes Unknown = new(4, "Unknown");
    public static readonly CerealTypes Wheaties = new(1, "Wheaties");

    public static readonly CerealTypes[] All =
    [
        None,
        Other,
        Unknown,
        Wheaties
    ];

    private CerealTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static CerealTypes Find(int id)
        => All.SingleOrDefault(CerealType => CerealType.Id == id);
}

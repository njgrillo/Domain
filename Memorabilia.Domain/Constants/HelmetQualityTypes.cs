namespace Memorabilia.Domain.Constants;

public sealed class HelmetQualityTypes : DomainItemConstants
{
    public static readonly HelmetQualityTypes Authentic = new(1, "Authentic", "AUTH");
    public static readonly HelmetQualityTypes Replica = new(2, "Replica", "REP");

    public static readonly HelmetQualityTypes[] All =
    [
        Authentic,
        Replica
    ];

    private HelmetQualityTypes(int id, string name, string abbreviation) 
        : base(id, name, abbreviation) { }

    public static HelmetQualityTypes Find(int id)
        => All.SingleOrDefault(helmetQualityType => helmetQualityType.Id == id);
}

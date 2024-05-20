namespace Memorabilia.Domain.Constants;

public sealed class JerseyQualityTypes : DomainItemConstants
{
    public static readonly JerseyQualityTypes Authentic = new(1, "Authentic");
    public static readonly JerseyQualityTypes Replica = new(2, "Replica");
    public static readonly JerseyQualityTypes China = new(3, "China");
    public static readonly JerseyQualityTypes Custom = new(4, "Custom");
    public static readonly JerseyQualityTypes Other = new(5, "Other");
    public static readonly JerseyQualityTypes Unknown = new(6, "Unknown");

    public static readonly JerseyQualityTypes[] All =
    [
        Authentic,
        China,
        Custom,
        Other,
        Replica,            
        Unknown
    ];

    private JerseyQualityTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static JerseyQualityTypes Find(int id)
        => All.SingleOrDefault(jerseyQualityType => jerseyQualityType.Id == id);
}

namespace Memorabilia.Domain.Constants;

public sealed class JerseyTypes : DomainItemConstants
{
    public static readonly JerseyTypes Stitched = new(1, "Stitched");
    public static readonly JerseyTypes ScreenPrint = new(2, "Screen Printed");
    public static readonly JerseyTypes Other = new(3, "Other");
    public static readonly JerseyTypes None = new(4, "None");
    public static readonly JerseyTypes Unknown = new(5, "Unknown");

    public static readonly JerseyTypes[] All =
    [
        Stitched,
        ScreenPrint,
        Other,
        None,
        Unknown
    ];

    private JerseyTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static JerseyTypes Find(int id)
        => All.SingleOrDefault(jerseyType => jerseyType.Id == id);
}

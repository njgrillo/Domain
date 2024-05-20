namespace Memorabilia.Domain.Constants;

public sealed class Orientations : DomainItemConstants
{
    public static readonly Orientations Portrait = new(1, "Portrait");
    public static readonly Orientations Landscape = new(2, "Landscape");

    public static readonly Orientations[] All =
    [
        Portrait,
        Landscape
    ];

    private Orientations(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Orientations Find(int id)
        => All.SingleOrDefault(orientation => orientation.Id == id);
}

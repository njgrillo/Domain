namespace Memorabilia.Domain.Constants;

public sealed class MagazineTypes : DomainItemConstants
{
    public static readonly MagazineTypes StandardPublication = new(1, "Standard Publication");
    public static readonly MagazineTypes Program = new(2, "Program");

    public static readonly MagazineTypes[] All =
    [
        StandardPublication,
        Program
    ];

    private MagazineTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static MagazineTypes Find(int id)
        => All.SingleOrDefault(magazineType => magazineType.Id == id);
}

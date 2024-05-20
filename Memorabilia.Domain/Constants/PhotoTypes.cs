namespace Memorabilia.Domain.Constants;

public sealed class PhotoTypes : DomainItemConstants
{
    public static readonly PhotoTypes Glossy = new(1, "Glossy");
    public static readonly PhotoTypes Matte = new(2, "Matte");
    public static readonly PhotoTypes Unknown = new(3, "Unknown");

    public static readonly PhotoTypes[] All =
    [
        Glossy,
        Matte,
        Unknown
    ];

    private PhotoTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static PhotoTypes Find(int id)
        => All.SingleOrDefault(photoType => photoType.Id == id);
}

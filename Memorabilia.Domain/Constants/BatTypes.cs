namespace Memorabilia.Domain.Constants;

public sealed class BatTypes : DomainItemConstants
{
    public static readonly BatTypes BigStick = new(1, "Big Stick");
    public static readonly BatTypes GameModel = new(2, "Game Model");
    public static readonly BatTypes Commemorative = new(3, "Commemorative");
    public static readonly BatTypes None = new(4, "None");
    public static readonly BatTypes Other = new(5, "Other");

    public static readonly BatTypes[] All =
    [
        BigStick,
        Commemorative,
        GameModel,            
        None,
        Other
    ];

    private BatTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static BatTypes Find(int id)
        => All.SingleOrDefault(batType => batType.Id == id);
}

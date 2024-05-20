namespace Memorabilia.Domain.Constants;

public sealed class Colors : DomainItemConstants
{
    public static readonly Colors Ash = new(8, "Ash");
    public static readonly Colors Black = new(2, "Black");
    public static readonly Colors Blonde = new(9, "Blonde");
    public static readonly Colors Blue = new(1, "Blue");
    public static readonly Colors Gold = new(4, "Gold");
    public static readonly Colors Orange = new(6, "Orange");
    public static readonly Colors Other = new(7, "Other");
    public static readonly Colors Red = new(5, "Red");
    public static readonly Colors Silver = new(3, "Silver");        
    public static readonly Colors Unknown = new(14, "Unknown");        
    public static readonly Colors White = new(10, "White");

    public static readonly Colors[] All =
    [
        Ash,
        Black,
        Blonde,
        Blue,
        Gold,
        Orange,
        Other,
        Red,
        Silver,
        Unknown,
        White
    ];

    public static readonly Colors[] Autograph =
    [
        Black,
        Blue,
        Gold,
        Orange,
        Other,
        Red,
        Silver,
        Unknown,
        White
    ];

    public static readonly Colors[] Bat =
    [
        Ash,
        Black,
        Blonde,
        Blue,
        Gold,
        Other,
        Red,
        Unknown
    ];

    private Colors(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Colors Find(int id)
        => All.SingleOrDefault(color => color.Id == id);

    public static Colors Find(string name)
        => All.SingleOrDefault(color => color.Name == name);

    public static Colors[] GetAll(ItemTypes itemType)
    {
        if (itemType == null)
            return All;

        if (itemType == ItemTypes.Bat)
            return Bat;

        return All;
    }
}

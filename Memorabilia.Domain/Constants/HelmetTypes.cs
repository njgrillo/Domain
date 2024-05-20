namespace Memorabilia.Domain.Constants;

public sealed class HelmetTypes : DomainItemConstants
{
    public static readonly HelmetTypes F7 = new(5, "F7");
    public static readonly HelmetTypes Flex = new(1, "Flex");
    public static readonly HelmetTypes Other = new(6, "Other");
    public static readonly HelmetTypes Revolution = new(4, "Revolution");
    public static readonly HelmetTypes Speed = new(3, "Speed");        
    public static readonly HelmetTypes VSR4 = new(7, "VSR4");        

    public static readonly HelmetTypes[] All =
    [
        F7,
        Flex,
        Other,
        Revolution,
        Speed,
        VSR4
    ];

    public static readonly HelmetTypes[] GameWorthly =
    [
        F7,
        Flex,
        Other,
        Revolution,
        Speed,
        VSR4
    ];

    private HelmetTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static HelmetTypes Find(int id)
        => All.SingleOrDefault(helmetType => helmetType.Id == id);

    public static HelmetTypes[] GetAll(GameStyleTypes gameStyleType)
    {
        if (gameStyleType == null || gameStyleType == GameStyleTypes.None)
            return All;

        return GameWorthly;
    }    
}

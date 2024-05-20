namespace Memorabilia.Domain.Constants;

public sealed class BasketballTypes : DomainItemConstants
{
    public static readonly BasketballTypes Official = new(1, "Official");
    public static readonly BasketballTypes Finals = new(2, "Finals");
    public static readonly BasketballTypes Commemorative = new(3, "Commemorative");
    public static readonly BasketballTypes Other = new(4, "Other");
    public static readonly BasketballTypes None = new(5, "None");

    public static readonly BasketballTypes[] All =
    [
        Commemorative,
        Finals,
        Official,
        None,
        Other
    ];

    public static readonly BasketballTypes[] GameWorthly =
    [
        Finals,
        Official
    ];

    private BasketballTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }    

    public static BasketballTypes Find(int id)
        => All.SingleOrDefault(basketballType => basketballType.Id == id);

    public static BasketballTypes[] GetAll(GameStyleTypes gameStyleType)
    {
        if (gameStyleType == null || gameStyleType == GameStyleTypes.None)
            return All;

        return GameWorthly;
    }
}

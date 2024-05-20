namespace Memorabilia.Domain.Constants;

public sealed class GameStyleTypes : DomainItemConstants
{
    public static readonly GameStyleTypes GameUsed = new(1, "Game Used");
    public static readonly GameStyleTypes GameWorn = new(2, "Game Worn");
    public static readonly GameStyleTypes GameIssued = new(3, "Game Issued");
    public static readonly GameStyleTypes MatchUsed = new(7, "Match Used");
    public static readonly GameStyleTypes None = new(4, "None");
    public static readonly GameStyleTypes Other = new(5, "Other");
    public static readonly GameStyleTypes TournametUsed = new(6, "Tournamet Used");

    public static readonly GameStyleTypes[] All =
    [
        GameUsed,
        GameWorn,
        GameIssued,
        None,
        Other,
        MatchUsed,
        TournametUsed
    ];

    public static readonly GameStyleTypes[] GameWorthly =
    [
        GameIssued,
        GameUsed,
        GameWorn,
        MatchUsed,
        TournametUsed
    ];

    public static readonly GameStyleTypes[] NonWearableStyles =
    [
        GameUsed,
        GameIssued,
        MatchUsed,
        None,
        Other,
        TournametUsed
    ];

    private GameStyleTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static GameStyleTypes Find(int id)
        => All.SingleOrDefault(gameStyleType => gameStyleType.Id == id);

    public static GameStyleTypes[] GetAll(ItemTypes itemType)
        => itemType.IsWearable()
            ? All
            : NonWearableStyles;
}

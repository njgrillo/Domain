namespace Memorabilia.Domain.Constants;

public sealed class FootballTypes : DomainItemConstants
{
    public static readonly FootballTypes Duke = new(1, "Duke");
    public static readonly FootballTypes DukeReplica = new(2, "Duke Replica");
    public static readonly FootballTypes Commemorative = new(3, "Commemorative");
    public static readonly FootballTypes Other = new(4, "Other");

    public static readonly FootballTypes[] All =
    [
        Commemorative,
        Duke,
        DukeReplica,            
        Other
    ];

    public static readonly FootballTypes[] GameWorthly =
    [
        Duke,
        Other
    ];

    private FootballTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static FootballTypes Find(int id)
        => All.SingleOrDefault(footballType => footballType.Id == id);

    public static FootballTypes[] GetAll(GameStyleTypes gameStyleType)
    {
        if (gameStyleType == null || gameStyleType == GameStyleTypes.None)
            return All;

        return GameWorthly;
    }
}

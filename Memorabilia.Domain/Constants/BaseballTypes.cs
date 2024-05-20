namespace Memorabilia.Domain.Constants;

public sealed class BaseballTypes : DomainItemConstants
{
    public static readonly BaseballTypes AllStar = new(2, "All Star");
    public static readonly BaseballTypes AllStarFuturesGame = new(19, "All Star Future's Game");
    public static readonly BaseballTypes AmericanLeague = new(7, "American League");
    public static readonly BaseballTypes Black = new(1, "Black Baseball", "ROMLBBG");
    public static readonly BaseballTypes Commemorative = new(12, "Commemorative");
    public static readonly BaseballTypes CyYoung = new(11, "Cy Young");
    public static readonly BaseballTypes FathersDay = new(9, "Father's Day");
    public static readonly BaseballTypes Gold = new(14, "Gold", "ROMLBG");
    public static readonly BaseballTypes GoldGlove = new(15, "Gold Glove", "RGGBB");
    public static readonly BaseballTypes GoldWorldSeries = new(17, "Gold World Series");
    public static readonly BaseballTypes HallOfFame = new(22, "Hall of Fame");
    public static readonly BaseballTypes HomeRunDerby = new(13, "Home Run Derby");
    public static readonly BaseballTypes MemorialDay = new(23, "Memorial Day");
    public static readonly BaseballTypes MothersDay = new(10, "Mother's Day", "ROMLBMOM");
    public static readonly BaseballTypes NationalLeague = new(8, "National League");
    public static readonly BaseballTypes None = new(6, "None");
    public static readonly BaseballTypes Official = new(4, "Official Major League Baseball", "ROMLB");
    public static readonly BaseballTypes OpeningDay = new(20, "Opening Day");
    public static readonly BaseballTypes Other = new(5, "Other");
    public static readonly BaseballTypes PostSeason = new(21, "Post Season");
    public static readonly BaseballTypes SpringTraining = new(16, "Spring Training");
    public static readonly BaseballTypes TeamAnniversary = new(18, "Team Anniversary");
    public static readonly BaseballTypes WorldSeries = new(3, "World Series");

    public static readonly BaseballTypes[] All =
    [
        AllStar,
        AllStarFuturesGame,
        AmericanLeague,
        Black,
        Commemorative,
        CyYoung,
        FathersDay,
        Gold,
        GoldGlove,
        GoldWorldSeries,
        HallOfFame,
        HomeRunDerby,
        MothersDay,
        NationalLeague,
        None,
        Official,
        OpeningDay,
        Other,
        PostSeason,
        SpringTraining,
        TeamAnniversary,
        WorldSeries
    ];

    public static readonly BaseballTypes[] Commissioner =
    [
        AllStar,
        AllStarFuturesGame,
        Black,
        Commemorative,
        CyYoung,
        FathersDay,
        Gold,
        GoldGlove,
        GoldWorldSeries,
        HallOfFame,
        HomeRunDerby,
        MothersDay,
        Official,
        OpeningDay,
        PostSeason,
        SpringTraining,
        TeamAnniversary,
        WorldSeries
    ];

    public static readonly BaseballTypes[] GameWorthly =
    [
        AllStar,
        AllStarFuturesGame,
        AmericanLeague,
        Commemorative,
        FathersDay,
        HomeRunDerby,
        MothersDay,
        NationalLeague,
        Official,
        OpeningDay,
        PostSeason,
        SpringTraining,
        TeamAnniversary,
        WorldSeries
    ];

    public static readonly BaseballTypes[] ImportByYear =
    [
        GoldWorldSeries,
        WorldSeries
    ];

    public static readonly BaseballTypes[] ImportByYearRange =
    [
        AllStar,
        GoldGlove
    ];

    public static readonly BaseballTypes[] LeaguePresident =
    [
        AmericanLeague,
        NationalLeague
    ];

    public static readonly BaseballTypes[] ProjectTypes =
    [
        AllStar,
        AllStarFuturesGame,
        AmericanLeague,
        Black,
        Commemorative,
        CyYoung,
        FathersDay,
        Gold,
        GoldGlove,
        GoldWorldSeries,
        HallOfFame,
        HomeRunDerby,
        MothersDay,
        NationalLeague,
        Official,
        OpeningDay,
        Other,
        PostSeason,
        SpringTraining,
        TeamAnniversary,
        WorldSeries
    ];

    public static readonly BaseballTypes[] Yearly =
    [
        AllStar,
        AllStarFuturesGame,
        Commemorative,
        GoldWorldSeries,
        HomeRunDerby,
        OpeningDay,
        Other,
        PostSeason,
        SpringTraining,
        WorldSeries
    ];

    private BaseballTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }   

    public static BaseballTypes Find(int id)
        => All.SingleOrDefault(BaseballTypes => BaseballTypes.Id == id);

    public static BaseballTypes[] GetAll(GameStyleTypes gameStyleType)
    {
        if (gameStyleType == null || gameStyleType == GameStyleTypes.None)
            return All;

        return GameWorthly;
    }
}

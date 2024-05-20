namespace Memorabilia.Domain.Constants;

public sealed class Leagues : DomainItemConstants
{
    public static readonly Leagues AmericanLeague = new(1, "American League", "AL");
    public static readonly Leagues NationalLeague = new(2, "National League", "NL");
    public static readonly Leagues NationalFootballLeague = new(3, "National Football League", "NFL");
    public static readonly Leagues AmericanFootballLeague = new(4, "American Football League", "AFL");
    public static readonly Leagues WesternLeague = new(5, "Western League");
    public static readonly Leagues AmericanAssociation = new(6, "American Association");

    public static Leagues[] All 
        => MLB.Union(NFL)
              .Distinct()   
              .ToArray();

    public static readonly Leagues[] MLB =
    [
        AmericanLeague,
        NationalLeague,
        AmericanAssociation,
        WesternLeague,
    ];

    public static readonly Leagues[] NFL =
    [
        NationalFootballLeague,
        AmericanFootballLeague
    ];

    private Leagues(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Leagues Find(int id)
        => All.SingleOrDefault(league => league.Id == id);

    public static Leagues[] GetAll(SportLeagueLevels sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevels.MajorLeagueBaseball)
            return MLB;

        if (sportLeagueLevel == SportLeagueLevels.NationalFootballLeague)
            return NFL;

        return All;
    }
}

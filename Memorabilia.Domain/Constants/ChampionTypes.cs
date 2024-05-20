namespace Memorabilia.Domain.Constants;

public sealed class ChampionTypes : DomainItemConstants
{   
    public static readonly ChampionTypes NBAFinals = new(4, "NBA Finals");
    public static readonly ChampionTypes StanleyCup = new(3, "Stanley Cup");
    public static readonly ChampionTypes SuperBowl = new(2, "Super Bowl", "SB");
    public static readonly ChampionTypes WorldSeries = new(1, "World Series", "WS");

    public static readonly ChampionTypes[] All =
    [
        NBAFinals,
        StanleyCup,
        SuperBowl,
        WorldSeries
    ];

    private ChampionTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static ChampionTypes Find(int id)
        => All.SingleOrDefault(championType => championType.Id == id);

    public static ChampionTypes Find(SportLeagueLevels sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevels.MajorLeagueBaseball)
            return WorldSeries;

        if (sportLeagueLevel == SportLeagueLevels.NationalBasketballAssociation)
            return NBAFinals;

        if (sportLeagueLevel == SportLeagueLevels.NationalFootballLeague)
            return SuperBowl;

        if (sportLeagueLevel == SportLeagueLevels.NationalHockeyLeague)
            return StanleyCup;

        return null;
    }

    public static ChampionTypes Find(Sports sport)
    {
        if (sport == Sports.Baseball)
            return WorldSeries;

        if (sport == Sports.Basketball)
            return NBAFinals;

        if (sport == Sports.Football)
            return SuperBowl;

        if (sport == Sports.Hockey)
            return StanleyCup;

        return null;
    }

    public override string ToString()
        => Abbreviation ?? Name;
}

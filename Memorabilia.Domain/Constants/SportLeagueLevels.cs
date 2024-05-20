namespace Memorabilia.Domain.Constants;

public sealed class SportLeagueLevels : DomainItemConstants
{
    public static readonly SportLeagueLevels AmericanBasketballAssociation = new(8, "American Basketball Association", "ABA", Sports.Basketball);
    public static readonly SportLeagueLevels AmericanFootballLeague = new(9, "American Football League", "AFL", Sports.Football);
    public static readonly SportLeagueLevels MajorLeagueBaseball = new(1, "Major League Baseball", "MLB", Sports.Baseball);
    public static readonly SportLeagueLevels NationalFootballLeague = new(2, "National Football League", "NFL", Sports.Football);
    public static readonly SportLeagueLevels NationalBasketballAssociation = new(3, "National Basketball Association", "NBA", Sports.Basketball);
    public static readonly SportLeagueLevels NationalHockeyLeague = new(4, "National Hockey League", "NHL", Sports.Hockey);

    public static readonly SportLeagueLevels[] All =
    [
        AmericanBasketballAssociation,
        AmericanFootballLeague,
        MajorLeagueBaseball,
        NationalBasketballAssociation,
        NationalFootballLeague,        
        NationalHockeyLeague
    ];

    public static readonly SportLeagueLevels[] Conference =
    [
        NationalBasketballAssociation,
        NationalFootballLeague,        
        NationalHockeyLeague
    ];

    private SportLeagueLevels(int id, string name, string abbreviation, Sports sport) 
        : base(id, name, abbreviation) 
    { 
        Sport = sport;
    }

    public Sports Sport { get; private set; }

    public static SportLeagueLevels Find(int id)
        => All.SingleOrDefault(sportLeagueLevel => sportLeagueLevel.Id == id);

    public static SportLeagueLevels Find(string name)
        => All.SingleOrDefault(sportLeagueLevel => sportLeagueLevel.Name == name);

    public static SportLeagueLevels[] GetAll(params int[] sportIds)
    {
        var sportLeagueLevels = new List<SportLeagueLevels>();

        if (sportIds.Contains(Sports.Baseball.Id))
            sportLeagueLevels.Add(MajorLeagueBaseball);

        if (sportIds.Contains(Sports.Basketball.Id))
        {
            sportLeagueLevels.Add(AmericanBasketballAssociation);
            sportLeagueLevels.Add(NationalBasketballAssociation);
        }            

        if (sportIds.Contains(Sports.Football.Id))
        {
            sportLeagueLevels.Add(AmericanFootballLeague);
            sportLeagueLevels.Add(NationalFootballLeague);
        }            

        if (sportIds.Contains(Sports.Hockey.Id))
            sportLeagueLevels.Add(NationalHockeyLeague);

        return sportLeagueLevels.OrderBy(sportLeagueLevel => sportLeagueLevel.Name).ToArray();
    }
}

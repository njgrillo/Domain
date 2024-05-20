namespace Memorabilia.Domain.Constants;

public sealed class Conferences : DomainItemConstants
{
    public static readonly Conferences AmericanFootballConference = new(1, "AFC - American Football Conference", "AFC");
    public static readonly Conferences NationalFootballConference = new(2, "NFC - National Football Conference", "NFC");
    public static readonly Conferences EasternConference = new(3, "Eastern Conference", "EAST");
    public static readonly Conferences WesternConference = new(4, "Western Conference", "WEST");
    public static readonly Conferences AmericanConference = new(5, "American Conference");
    public static readonly Conferences NFLEasternConference = new(6, "Eastern Conference");
    public static readonly Conferences NFLWesternConference = new(7, "Western Conference");
    public static readonly Conferences NFLNationalConference = new(8, "National Conference");
    public static readonly Conferences AllAmericanFootballConference = new(9, "All-America Football Conference");

    public static readonly Conferences[] All =
    [
        AmericanConference,
        AmericanFootballConference,
        NationalFootballConference,
        NFLEasternConference,
        NFLNationalConference,
        NFLWesternConference,
        EasternConference,
        WesternConference,
        AllAmericanFootballConference
    ];

    public static readonly Conferences[] NationalBasketballAssociation =
    [
        EasternConference,
        WesternConference
    ];

    public static readonly Conferences[] NationalFootballLeague =
    [
        AmericanFootballConference,
        NationalFootballConference,
        AllAmericanFootballConference,
        AmericanConference,
        NFLEasternConference,
        NFLNationalConference,
        NFLWesternConference
    ];

    private Conferences(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Conferences Find(int id)
        => All.SingleOrDefault(conference => conference.Id == id);

    public static Conferences[] GetAll(SportLeagueLevels sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevels.NationalBasketballAssociation)
            return NationalBasketballAssociation;

        if (sportLeagueLevel == SportLeagueLevels.NationalFootballLeague)
            return NationalFootballLeague;

        return All;
    }
}

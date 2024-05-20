namespace Memorabilia.Domain.Constants;

public sealed class Divisions : DomainItemConstants
{
    public static readonly Divisions AFCEast = new(1, "AFC East");
    public static readonly Divisions AFCNorth = new(2, "AFC North");
    public static readonly Divisions AFCSouth = new(3, "AFC South");
    public static readonly Divisions AFCWest = new(4, "AFC West");
    public static readonly Divisions NFCEast = new(6, "NFC East");
    public static readonly Divisions NFCNorth = new(5, "NFC North");
    public static readonly Divisions NFCSouth = new(7, "NFC South");
    public static readonly Divisions NFCWest = new(8, "NFC West");
    public static readonly Divisions Century = new(9, "NFL - Century Division");
    public static readonly Divisions WesternDivision = new(10, "NFL - Western Division");
    public static readonly Divisions Coastal = new(11, "NFL - Coastal Division");
    public static readonly Divisions AFCCentral = new(12, "AFC Central");
    public static readonly Divisions NFCCentral = new(13, "NFC Central");
    public static readonly Divisions EasternDivision = new(14, "NFL - Eastern Division");
    public static readonly Divisions CentralDivision = new(15, "NFL - Central Division");
    public static readonly Divisions AFLWest = new(16, "AFL West");
    public static readonly Divisions Capitol = new(17, "Capitol Division");
    public static readonly Divisions ALEast = new(18, "AL East");
    public static readonly Divisions ALCentral = new(19, "AL Central");
    public static readonly Divisions ALWest = new(20, "AL West");
    public static readonly Divisions NLEast = new(21, "NL East");
    public static readonly Divisions NLCentral = new(22, "NL Central");
    public static readonly Divisions NLWest = new(23, "NL West");

    public static readonly Divisions[] All =
    [
        AFCEast,
        AFCNorth,
        AFCSouth,
        AFCWest,
        NFCEast,
        NFCNorth,
        NFCSouth,
        NFCWest,
        Century,
        WesternDivision,
        Coastal,
        AFCCentral,
        NFCCentral,
        EasternDivision,
        CentralDivision,
        AFLWest,
        Capitol,
        ALEast,
        ALCentral,
        ALWest,
        NLEast,
        NLCentral,
        NLWest
    ];

    public static readonly Divisions[] MajorLeagueBaseball =
    [
        ALEast,
        ALCentral,
        ALWest,
        NLEast,
        NLCentral,
        NLWest
    ];

    public static readonly Divisions[] NationalFootballLeague =
    [
        AFCEast,
        AFCNorth,
        AFCSouth,
        AFCWest,
        NFCEast,
        NFCNorth,
        NFCSouth,
        NFCWest,
        AFCCentral,
        NFCCentral,
        AFLWest,
        Capitol,
        Century,
        Coastal,
        CentralDivision,
        EasternDivision,
        WesternDivision
    ];

    private Divisions(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Divisions Find(int id)
        => All.SingleOrDefault(Division => Division.Id == id);

    public static Divisions[] GetAll(SportLeagueLevels sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevels.MajorLeagueBaseball)
            return MajorLeagueBaseball;

        if (sportLeagueLevel == SportLeagueLevels.NationalFootballLeague)
            return NationalFootballLeague;

        return All;
    }
}

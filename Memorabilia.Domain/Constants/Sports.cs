namespace Memorabilia.Domain.Constants;

public sealed class Sports : DomainItemConstants
{
    public static readonly Sports AutoRacing = new(17, "Auto Racing");
    public static readonly Sports Baseball = new(1, "Baseball");
    public static readonly Sports Basketball = new(2, "Basketball");
    public static readonly Sports Boxing = new(11, "Boxing");
    public static readonly Sports Cycling = new(16, "Cycling");
    public static readonly Sports Diving = new(18, "Diving");
    public static readonly Sports FigureSkating = new (19, "Figure Skating");
    public static readonly Sports Football = new(3, "Football");
    public static readonly Sports Golf = new(6, "Golf");
    public static readonly Sports Gymnastics = new(20, "Gymnastics");
    public static readonly Sports Hockey = new(4, "Hockey");
    public static readonly Sports HorseRacing = new(15, "Horse Racing");
    public static readonly Sports MixedMartialArts = new(12, "Mixed Martial Arts");
    public static readonly Sports Skiing = new(22, "Skiing");
    public static readonly Sports Soccer= new(5, "Soccer", "Futbol");
    public static readonly Sports SpeedSkating = new (21, "Speed Skating");
    public static readonly Sports Swimming = new(14, "Swimming");
    public static readonly Sports Tennis= new(7, "Tennis");
    public static readonly Sports TrackAndField= new(13, "Track & Field");

    public static readonly Sports[] All =
    [
        AutoRacing,
        Baseball,
        Basketball,
        Boxing,
        Cycling,
        Diving,
        FigureSkating,
        Football,
        Golf,
        Gymnastics,
        Hockey,
        HorseRacing,
        MixedMartialArts,
        Skiing,
        Soccer,
        SpeedSkating,
        Swimming,
        Tennis,
        TrackAndField
    ];

    public static readonly Sports[] AllStarGameSports =
    [
        Baseball,
        Basketball,
        Hockey
    ];

    public static readonly Sports[] GloveSports =
    [
        Baseball,
        Boxing,
        Football,
        Golf,
        Hockey,
        MixedMartialArts,
        Soccer
    ];

    public static readonly Sports[] JerseySports =
    [
        Baseball,
        Basketball,
        Football,
        Hockey    
    ];

    public static readonly Sports[] PositionSports =
    [
        Baseball,
        Basketball,
        Football,
        Hockey,
        Soccer
    ];

    public static readonly Sports[] ProBowlGameSports =
    [
        Football
    ];

    public static readonly Sports[] ShoeSports =
    [
        Baseball,
        Basketball,
        Boxing,
        Cycling,
        Football,
        Golf,
        Soccer,
        TrackAndField
    ];

    public static readonly Sports[] TrunkSports =
    [
        Boxing,
        MixedMartialArts,
        Swimming
    ];

    public static readonly Sports[] WristBandSports =
    [
        Baseball,
        Basketball,
        Football,
        Soccer,
        Tennis
    ];

    private Sports(int id, string name, string alternateName = null) 
        : base(id, name)
    {
        AlternateName = alternateName;
    }

    public string AlternateName { get; }

    public static Sports Find(int id)
        => All.SingleOrDefault(sport => sport.Id == id);

    public static Sports Find(string name)
        => All.SingleOrDefault(sport => sport.Name == name);

    public static Sports[] GetAll(ItemTypes itemType)
    {
        if (itemType == ItemTypes.Glove)
            return GloveSports;

        if (itemType == ItemTypes.Jersey || itemType == ItemTypes.JerseyNumber)
            return JerseySports;

        if (itemType == ItemTypes.Shoe)
            return ShoeSports;

        if (itemType == ItemTypes.Trunks)
            return TrunkSports;

        if (itemType == ItemTypes.WristBand)
            return WristBandSports;

        return All;
    }

    public static bool HasAllStarGames(params Sports[] sports)
        => sports.Any(sport => AllStarGameSports.Contains(sport));

    public static bool HasProBowlGames(params Sports[] sports)
        => sports.Any(sport => ProBowlGameSports.Contains(sport));

    public static bool IsPositionSport(params Sports[] sports)
        => sports.Any(sport => PositionSports.Contains(sport));
}

namespace Memorabilia.Domain.Constants;

public sealed class InternationalHallOfFameTypes : DomainItemConstants
{
    public static readonly InternationalHallOfFameTypes CanadianHallOfFame = new(1, "Canadian Hall of Fame");
    public static readonly InternationalHallOfFameTypes CaribbeanHallOfFame = new(2, "Caribbean Hall of Fame");
    public static readonly InternationalHallOfFameTypes CubanHallOfFame = new(7, "Cuban Hall of Fame");
    public static readonly InternationalHallOfFameTypes JapaneseHallOfFame = new(3, "Japanese Hall of Fame");
    public static readonly InternationalHallOfFameTypes MexicanHallOfFame = new(4, "Mexican Hall of Fame");
    
    public static readonly InternationalHallOfFameTypes[] All =
    [
        CanadianHallOfFame,
        CaribbeanHallOfFame,
        CubanHallOfFame,
        JapaneseHallOfFame,
        MexicanHallOfFame
    ];

    private InternationalHallOfFameTypes(int id, string name) 
        : base(id, name) { }

    public static InternationalHallOfFameTypes Find(int id)
        => All.SingleOrDefault(internationalHallOfFameType => internationalHallOfFameType.Id == id);
}

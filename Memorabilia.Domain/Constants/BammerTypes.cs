namespace Memorabilia.Domain.Constants;

public sealed class BammerTypes : DomainItemConstants
{
    public static readonly BammerTypes BabyBammer = new(1, "Baby Bammer");
    public static readonly BammerTypes Bammer = new(2, "Bammer");
    public static readonly BammerTypes BammBeano = new(3, "Bamm Beano");
    public static readonly BammerTypes BigBammer = new(4, "Big Bammer");
    public static readonly BammerTypes OpeningDay = new(5, "Opening Day Bammer");

    public static readonly BammerTypes[] All =
    [
        BabyBammer,
        Bammer,
        BammBeano,
        BigBammer,
        OpeningDay
    ];

    private BammerTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static BammerTypes Find(int id)
        => All.SingleOrDefault(bammerType => bammerType.Id == id);
}

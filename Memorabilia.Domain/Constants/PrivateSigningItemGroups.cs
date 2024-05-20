namespace Memorabilia.Domain.Constants;

public sealed class PrivateSigningItemGroups : DomainItemConstants
{
    public static readonly PrivateSigningItemGroups BallsFlats = new(1, "Balls & Flats");
    public static readonly PrivateSigningItemGroups Cards = new(2, "Cards");
    public static readonly PrivateSigningItemGroups Equipment = new(3, "Equipment");
    public static readonly PrivateSigningItemGroups Flats = new(4, "Flats");
    public static readonly PrivateSigningItemGroups FlatsUpToEleven = new(5, "Flats to 11x14");
    public static readonly PrivateSigningItemGroups FlatsUpToElevenIncludeBalls = new(6, "Flats to 11x14/Balls");
    public static readonly PrivateSigningItemGroups FlatsUpToSixteen = new(7, "Flats to 16x20");
    public static readonly PrivateSigningItemGroups FlatsUpToSixteenIncludeBalls = new(8, "Flats to 16x20/Balls");
    public static readonly PrivateSigningItemGroups LargeFlats = new(9, "Large Flats");
    public static readonly PrivateSigningItemGroups Other = new(10, "Other");
    public static readonly PrivateSigningItemGroups Premium = new(11, "Premium");

    public static readonly PrivateSigningItemGroups[] All =
    [
        BallsFlats,
        Cards,
        Equipment,
        Flats,
        FlatsUpToEleven,
        FlatsUpToElevenIncludeBalls,
        FlatsUpToSixteen,
        FlatsUpToSixteenIncludeBalls,
        LargeFlats,
        Other,
        Premium
    ];

    private PrivateSigningItemGroups(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static PrivateSigningItemGroups Find(int id)
        => All.SingleOrDefault(PrivateSigningItemGroups => PrivateSigningItemGroups.Id == id);
}

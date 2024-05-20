namespace Memorabilia.Domain.Constants;

public sealed class Sizes : DomainItemConstants
{
    public static readonly Sizes Eight = new(1027, "8");
    public static readonly Sizes EightByTen = new(11, "8x10");
    public static readonly Sizes Eleven = new(1031, "11");
    public static readonly Sizes ElevenByFourteen = new(12, "11x14");
    public static readonly Sizes ElevenHalf = new(1032, "11.5");
    public static readonly Sizes ExtraExtraLarge = new(1018, "Extra Extra Large", "XXL");
    public static readonly Sizes ExtraLarge = new(10, "Extra Large", "XL");
    public static readonly Sizes Fifty = new(1023, "50");
    public static readonly Sizes FiftyEight = new(1026, "58");
    public static readonly Sizes FiftyFour = new(1017, "54");
    public static readonly Sizes FiftySix = new(1019, "56", "XXXL");
    public static readonly Sizes FiftyTwo = new(1016, "52");
    public static readonly Sizes FortyEight = new(1025, "48");
    public static readonly Sizes FortyFour = new(1015, "44");
    public static readonly Sizes Full = new(2, "Full Size");
    public static readonly Sizes Gumball = new(1035, "Gumball");
    public static readonly Sizes Large = new(3, "Large", "L");
    public static readonly Sizes Medium = new(9, "Medium", "M");
    public static readonly Sizes Micro = new(1034, "Micro");
    public static readonly Sizes Mini = new(1, "Mini");    
    public static readonly Sizes Nine = new(1028, "9");
    public static readonly Sizes None = new(8, "None");
    public static readonly Sizes Other = new(7, "Other");
    public static readonly Sizes Oversized = new(6, "Oversized");
    public static readonly Sizes SixteenByTwenty = new(13, "16x20");
    public static readonly Sizes Sixty = new(1024, "60");
    public static readonly Sizes Small = new(4, "Small", "S");
    public static readonly Sizes Standard = new(5, "Standard");
    public static readonly Sizes Ten = new(1029, "10");
    public static readonly Sizes TenHalf = new(1030, "10.5");
    public static readonly Sizes ThreeByFive = new(15, "3x5");
    public static readonly Sizes Twelve = new(1033, "12");
    public static readonly Sizes TwentyByThirty = new(14, "20x30");
    public static readonly Sizes Unknown = new(1022, "Unknown");

    public static readonly Sizes[] All =
    [
        Eight,
        EightByTen,
        Eleven,
        ElevenByFourteen,
        ElevenHalf,
        ExtraExtraLarge,
        ExtraLarge,
        Fifty,
        FiftyEight,
        FiftyFour,
        FiftySix,
        FiftyTwo,
        FortyEight,
        FortyFour,
        Full,
        Gumball,
        Large,
        Medium,
        Micro,
        Mini,
        Nine,
        None,
        Other,
        Oversized,
        SixteenByTwenty,
        Sixty,
        Small,
        Standard,
        Ten,
        TenHalf,
        ThreeByFive,
        Twelve,
        TwentyByThirty,
        Unknown
    ];

    private Sizes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Sizes Find(int id)
        => All.SingleOrDefault(size => size.Id == id);

    public static Sizes Find(string name)
        => All.SingleOrDefault(size => size.Name == name);
}

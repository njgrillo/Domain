namespace Memorabilia.Domain.Constants;

public sealed class Brands : DomainItemConstants
{
    public static readonly Brands Adidas = new(4, "Adidas");
    public static readonly Brands Beckett = new(14, "Beckett");
    public static readonly Brands Callaway = new(24, "Callaway");
    public static readonly Brands CCM = new(26, "CCM");
    public static readonly Brands Champion = new(1032, "Champion");
    public static readonly Brands Easton = new(1026, "Easton");
    public static readonly Brands Everlast = new(1036, "Everlast");
    public static readonly Brands Fender = new(22, "Fender");
    public static readonly Brands Fotoball = new(27, "Fotoball");
    public static readonly Brands Funko = new(19, "Funko Inc.");
    public static readonly Brands GeneralMills = new (1037, "General Mills");
    public static readonly Brands Hasbro = new(18, "Hasbro");
    public static readonly Brands HighSchoolDayz = new(1030, "High School Dayz");
    public static readonly Brands Kenner = new(17, "Kenner");
    public static readonly Brands Lindys = new(1039, "Lindy's");
    public static readonly Brands LouisvilleSlugger = new(1025, "Louisville Slugger", "LS");
    public static readonly Brands Majestic = new(5, "Majestic");
    public static readonly Brands MitchellAndNess = new(1022, "Mitchell & Ness", "MN");
    public static readonly Brands Mizuno = new(1038, "Mizuno");
    public static readonly Brands Muslady = new(21, "Muslady");
    public static readonly Brands NewEra = new(25, "New Era");
    public static readonly Brands Nike = new(2, "Nike");
    public static readonly Brands None = new(8, "None");
    public static readonly Brands Other = new(7, "Other");
    public static readonly Brands Photofile = new(12, "Photofile");
    public static readonly Brands PlayersOfTheCentury = new (1034, "Players of the Century");
    public static readonly Brands Rawlings = new(1, "Rawlings");
    public static readonly Brands Reach = new(28, "Reach");
    public static readonly Brands Reebok = new(3, "Reebok", "RBK");  
    public static readonly Brands Riddell = new(11, "Riddell");
    public static readonly Brands Russell = new(1028, "Russell");
    public static readonly Brands Salvino = new(20, "Salvino");
    public static readonly Brands Spalding = new(10, "Spalding");  
    public static readonly Brands Spinneybeck = new(9, "Spinneybeck");  
    public static readonly Brands SportsIllustrated = new(13, "Sports Illustrated", "SI");
    public static readonly Brands Starter = new(1035, "Starter");
    public static readonly Brands TeamSpirit = new (1033, "Team Spirit");
    public static readonly Brands TeamworkAthleticApparel = new(1027, "Teamwork Athelic Apparel");
    public static readonly Brands Titleist = new(23, "Titleist");
    public static readonly Brands Topps = new(15, "Topps");  
    public static readonly Brands Unknown = new(1031, "Unknown");  
    public static readonly Brands UpperDeck = new(16, "Upper Deck", "UD");  
    public static readonly Brands XavierProline = new(1029, "Xavier Proline");  
    public static readonly Brands Wilson = new(6, "Wilson");

    public static readonly Brands[] All =
    [
        Adidas,
        Beckett,
        Callaway,
        CCM,
        Champion,
        Easton,
        Everlast,
        Fender,
        Fotoball,
        Funko,
        GeneralMills,
        Hasbro,
        HighSchoolDayz,
        Kenner,
        Lindys,
        LouisvilleSlugger,
        Majestic,
        MitchellAndNess,
        Mizuno,
        Muslady,
        NewEra,
        Nike,
        None,
        Other,
        Photofile,
        PlayersOfTheCentury,
        Rawlings,
        Reach,
        Reebok,
        Riddell,
        Russell,
        Salvino,
        Spalding,
        Spinneybeck,
        SportsIllustrated,
        Starter,
        TeamSpirit,
        TeamworkAthleticApparel,
        Titleist,
        Topps,
        Unknown,
        UpperDeck,
        XavierProline,
        Wilson
    ];

    public static readonly Brands[] GameWorthlyBaseballBrand =
    [
        Rawlings,
        Reach,
        Spalding
    ];

    private Brands(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Brands Find(int id)
        => All.SingleOrDefault(brand => brand.Id == id);

    public static Brands Find(string name)
        => All.SingleOrDefault(brand => brand.Name == name);
}

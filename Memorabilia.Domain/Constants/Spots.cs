namespace Memorabilia.Domain.Constants;

public sealed class Spots : DomainItemConstants
{
    public static readonly Spots BackCloth = new(24, "Back - On Cloth");
    public static readonly Spots BackCover = new(6, "Back Cover");
    public static readonly Spots BackNumber = new(21, "Back - On Number");
    public static readonly Spots BottomLeft = new(17, "Bottom - Facemask Facing Left");
    public static readonly Spots BottomRight = new(16, "Bottom - Facemask Facing Right");
    public static readonly Spots Crown = new(20, "Crown");
    public static readonly Spots FrontCloth = new(22, "Front - On Cloth");
    public static readonly Spots FrontCover = new(5, "Front Cover");
    public static readonly Spots FrontNumber = new(23, "Front - On Number");
    public static readonly Spots Inside = new(7, "Inside");
    public static readonly Spots LeftSide = new(39, "Left Side");
    public static readonly Spots MiddleLeft = new(19, "Middle - Facemask Facing Left");
    public static readonly Spots MiddleRight = new(18, "Middle - Facemask Facing Right");
    public static readonly Spots OnBack = new(10, "On Back");
    public static readonly Spots OnBase = new(29, "On Base");
    public static readonly Spots OnBear = new(28, "On Bear");
    public static readonly Spots OnBlade = new(37, "On Blade");
    public static readonly Spots OnBooklet = new(34, "On Booklet");
    public static readonly Spots OnBookplate = new(8, "On Bookplate");
    public static readonly Spots OnBox = new(31, "On Box");
    public static readonly Spots OnBrimBottomSide = new(42, "On Brim - Bottom Side");
    public static readonly Spots OnBrimTopSide = new(41, "On Brim - Top Side");
    public static readonly Spots OnCardboard = new(12, "On Cardboard");
    public static readonly Spots OnCD = new(35, "On CD");
    public static readonly Spots OnCloth = new(3, "On Cloth");
    public static readonly Spots OnFront = new(9, "On Front");
    public static readonly Spots OnHat = new(30, "On Hat");
    public static readonly Spots OnNumber = new(4, "On Number");        
    public static readonly Spots OnPackage = new(25, "On Package");        
    public static readonly Spots OnPlastic = new(11, "On Plastic");        
    public static readonly Spots OnPlasticTagProtector = new(27, "On Plastic Tag Protector");        
    public static readonly Spots OnStick = new(36, "On Stick");        
    public static readonly Spots OnTag = new(26, "On Tag");        
    public static readonly Spots RightSide = new (38, "Right Side");        
    public static readonly Spots SidePanel = new(2, "Side Panel");
    public static readonly Spots SweetSpot = new(1, "Sweet Spot");
    public static readonly Spots Top = new(40, "Top");
    public static readonly Spots TopLeft = new(15, "Top - Facemask Facing Left");
    public static readonly Spots TopRight = new(14, "Top - Facemask Facing Right");
    public static readonly Spots UnderLogo = new(13, "Under Logo");

    public static readonly Spots[] All =
    [
        BackCloth,
        BackCover,
        BackNumber,
        BottomLeft,
        BottomRight,
        Crown,
        FrontCloth,
        FrontCover,
        FrontNumber,
        Inside,
        LeftSide,
        MiddleLeft,
        MiddleRight,
        OnBack,
        OnBase,
        OnBear,
        OnBlade,
        OnBooklet,
        OnBookplate,
        OnBox,
        OnBrimBottomSide,
        OnBrimTopSide,
        OnCardboard,
        OnCD,
        OnCloth,
        OnFront,
        OnHat,
        OnNumber, 
        OnPackage,
        OnPlastic,
        OnPlasticTagProtector,
        OnStick,
        OnTag,
        RightSide,
        SidePanel,
        SweetSpot,
        Top,
        TopLeft,
        TopRight,
        UnderLogo
    ];

    private Spots(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Spots Find(int id)
        => All.SingleOrDefault(spot => spot.Id == id);

    public static Spots Find(string name)
        => All.SingleOrDefault(spot => spot.Name == name);
}

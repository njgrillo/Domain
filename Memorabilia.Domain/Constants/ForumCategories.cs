namespace Memorabilia.Domain.Constants;

public sealed class ForumCategories : DomainItemConstants
{
    public static readonly ForumCategories AddressRequests = new(1, "Address Requests", canBeSportRelated: true);
    public static readonly ForumCategories Buy = new(2, "Buy", canBeSportRelated: true);
    public static readonly ForumCategories Consignments = new(3, "Consignments", canBeSportRelated: true);
    public static readonly ForumCategories InPersonGraphin = new (4, "In Person Graphin'", canBeSportRelated: true);
    public static readonly ForumCategories Miscellaneous = new(5, "Miscellaneous", canBeSportRelated: false);
    public static readonly ForumCategories PrivateSignings = new(6, "Private Signings", canBeSportRelated: true);
    public static readonly ForumCategories Resources = new(7, "Resources", canBeSportRelated: false);
    public static readonly ForumCategories Sell = new(8, "Sell", canBeSportRelated: true);
    public static readonly ForumCategories SigningInterest = new(9, "Signing Interest", canBeSportRelated: true);
    public static readonly ForumCategories ThroughTheMail = new(10, "Through the Mail (TTM)", canBeSportRelated: true);
    public static readonly ForumCategories TipsAndTricks = new(12, "Tips & Tricks", canBeSportRelated: false);
    public static readonly ForumCategories Trade = new(11, "Trade", canBeSportRelated: true);    
    public static readonly ForumCategories Vouches = new(13, "Vouches", canBeSportRelated: false);

    public bool CanBeSportRelated { get; private set; }

    public static readonly ForumCategories[] All =
    [
        AddressRequests,
        Buy,
        Consignments,
        InPersonGraphin,
        Miscellaneous,
        PrivateSignings,
        Resources,
        Sell,
        SigningInterest,
        ThroughTheMail,
        TipsAndTricks,
        Trade,
        Vouches
    ];

    public static readonly ForumCategories[] SportRelated =
    [
        AddressRequests,
        Buy,
        Consignments,
        InPersonGraphin,
        PrivateSignings,
        Sell,
        SigningInterest,
        ThroughTheMail,
        Trade       
    ];

    private ForumCategories(int id, string name, bool canBeSportRelated, string abbreviation = null)
        : base(id, name, abbreviation) 
    { 
        CanBeSportRelated = canBeSportRelated;
    }

    public static bool CanHaveSport(int id)
        => SportRelated.Any(ForumCategories => ForumCategories.Id == id);

    public static ForumCategories Find(int id)
        => All.SingleOrDefault(ForumCategories => ForumCategories.Id == id);
}

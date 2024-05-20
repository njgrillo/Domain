namespace Memorabilia.Domain.Constants;

public class Permissions : DomainItemConstants
{    
    public static readonly Permissions Collection = new(2, "Collection");
    public static readonly Permissions Consignment = new(3, "Consignment");   
    public static readonly Permissions Memorabilia = new(5, "MemorabiliaTracking");
    public static readonly Permissions Message = new(6, "Message");
    public static readonly Permissions PrivateSigning = new(7, "PrivateSigning");
    public static readonly Permissions Project = new(8, "Project");
    public static readonly Permissions Search = new(9, "Search");    
    public static readonly Permissions ThroughTheMail = new(12, "ThroughTheMail");
    public static readonly Permissions Tools = new(13, "Tools");


    public static readonly Permissions BuySellTrade = new(1, "BuySellTrade");
    public static readonly Permissions EditForum = new(4, "EditForum");
    public static readonly Permissions EditForumBookmark = new(16, "EditForumBookmark");
    public static readonly Permissions EditSignatureAuthentication = new(15, "EditSignatureAuthentication");
    public static readonly Permissions EditSignatureIdentification = new(11, "EditSignatureIdentification");


    public static readonly Permissions[] All =
    [       
        Collection,
        Consignment,         
        Memorabilia, 
        Message, 
        PrivateSigning,
        Project,
        Search,   
        ThroughTheMail,
        Tools,

        BuySellTrade,
        EditForum,
        EditForumBookmark,
        EditSignatureAuthentication,
        EditSignatureIdentification,
    ];

    private Permissions(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static Permissions Find(int id)
        => All.SingleOrDefault(permission => permission.Id == id);

    public static Permissions FindByName(string name)
        => All.SingleOrDefault(permission => permission.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}

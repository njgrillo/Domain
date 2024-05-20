namespace Memorabilia.Domain.Constants;

public sealed class HelpItems : DomainItemConstants
{
    public static readonly HelpItems Home = new(1, "Home");
    public static readonly HelpItems Consignments = new(2, "Consignments");
    public static readonly HelpItems MyStuff = new(3, "My Stuff", hasChildren: true);
    public static readonly HelpItems MyStuffCollections = new(4, "Collections", MyStuff);
    public static readonly HelpItems MyStuffDashboard = new(5, "Dashboard", MyStuff);
    public static readonly HelpItems MyStuffFeeback = new(6, "Feedback", MyStuff);
    public static readonly HelpItems MyStuffForSale = new(7, "For Sale", MyStuff);
    public static readonly HelpItems MyStuffForTrade = new(8, "For Trade", MyStuff);
    public static readonly HelpItems MyStuffForumBookmarks = new(9, "Forum Bookmarks", MyStuff);
    public static readonly HelpItems MyStuffMemorabilia = new(10, "Memorabilia", MyStuff);
    public static readonly HelpItems MyStuffMessages = new(11, "Messages", MyStuff);
    public static readonly HelpItems MyStuffOffers = new(12, "Offers", MyStuff);
    public static readonly HelpItems MyStuffPrivateSignings = new(13, "Private Signings", MyStuff);
    public static readonly HelpItems MyStuffProjects = new(14, "Projects", MyStuff);
    public static readonly HelpItems MyStuffProposedTrades = new(15, "Proposed Trades", MyStuff);
    public static readonly HelpItems MyStuffSavedSearches = new(16, "Saved Searches", MyStuff);
    public static readonly HelpItems MyStuffSettings = new(17, "Settings", MyStuff);
    public static readonly HelpItems MyStuffThroughTheMail = new(18, "Through the Mail", MyStuff);
    public static readonly HelpItems MyStuffTransactions = new(19, "Transactions", MyStuff);
    public static readonly HelpItems Forums = new(20, "Forums");
    public static readonly HelpItems Memorabilia = new(21, "Memorabilia");
    public static readonly HelpItems PrivateSignings = new(22, "Private Signings");
    public static readonly HelpItems SignatureAuthentication = new(23, "Signature Authentication");
    public static readonly HelpItems SignatureIdentification = new(24, "Signature Identification");
    public static readonly HelpItems Tools = new(25, "Tools", hasChildren: true);
    public static readonly HelpItems ToolsPersonProfile = new(26, "Person Profile", Tools);
    public static readonly HelpItems ToolsBaseball = new(27, "Baseball", Tools);
    public static readonly HelpItems ToolsBasketball = new(28, "Basketball", Tools);
    public static readonly HelpItems ToolsFootball = new(29, "Football", Tools);
    public static readonly HelpItems ToolsHockey = new(30, "Hockey", Tools);
    public static readonly HelpItems ToolsMultiSport= new(31, "Multi Sport", Tools);
    public static readonly HelpItems MyStuffSignatureAuthentication = new(32, "Signature Authentication", MyStuff);
    public static readonly HelpItems MyStuffSignatureIdentification = new(33, "Signature Identification", MyStuff);

    public static readonly HelpItems[] All =
    [
        Home,
        Consignments,
        MyStuff,
        MyStuffCollections,
        MyStuffDashboard,
        MyStuffFeeback,
        MyStuffForSale,
        MyStuffForTrade,
        MyStuffForumBookmarks,
        MyStuffMemorabilia,
        MyStuffMessages,
        MyStuffOffers,
        MyStuffPrivateSignings,
        MyStuffProjects,
        MyStuffProposedTrades,
        MyStuffSavedSearches,
        MyStuffSettings,
        MyStuffSignatureAuthentication,
        MyStuffSignatureIdentification,
        MyStuffThroughTheMail,
        MyStuffTransactions,
        Forums,
        Memorabilia,
        PrivateSignings,
        SignatureAuthentication,
        SignatureIdentification,
        Tools,
        ToolsPersonProfile,
        ToolsBaseball,
        ToolsBasketball,
        ToolsFootball,
        ToolsHockey,
        ToolsMultiSport
    ];

    public static readonly HelpItems[] Parents =
    [
        Home,
        Consignments,
        MyStuff,
        Forums,
        Memorabilia,
        PrivateSignings,
        SignatureAuthentication,
        SignatureIdentification,
        Tools
    ];

    public bool HasChildren { get; private set; } 

    public HelpItems Parent { get; private set; }

    private HelpItems(int id, string name, bool? hasChildren = false)
        : base(id, name) 
    {
        HasChildren = hasChildren ?? false;
    }

    private HelpItems(int id, string name, HelpItems parent)
        : base(id, name)
    {
        Parent = parent;
    }

    public static HelpItems[] GetChildren(HelpItems helpItem)
        => All.Where(item => item.Parent != null && item.Parent.Id == helpItem.Id)
              .ToArray();

    public override string ToString()
        => Parent != null 
            ? $"{Parent.Name.Replace(" ", "")}{Name.Replace(" ", "")}"
            : Name.Replace(" ", "");
}

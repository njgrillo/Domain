namespace Memorabilia.Domain.Constants;

public sealed class AuthenticationCompanies : DomainItemConstants
{
    public static readonly AuthenticationCompanies Beckett = new(2, "Beckett Authentication Services", "BAS");
    public static readonly AuthenticationCompanies Fanatics = new(7, "Fanatics");
    public static readonly AuthenticationCompanies JSA = new(1, "James Spence Authentication", "JSA", @"https://www.spenceloa.com/verify-authenticity/results?certificateNumber=");
    public static readonly AuthenticationCompanies Leaf = new(9, "Leaf");
    public static readonly AuthenticationCompanies MAB = new(10, "MAB Celebrity Services", "MAB");
    public static readonly AuthenticationCompanies MajorLeagueBaseball = new(8, "Major League Baseball", "MLB");
    public static readonly AuthenticationCompanies Other = new(12, "Other");
    public static readonly AuthenticationCompanies Player = new(4, "Player Hologram");
    public static readonly AuthenticationCompanies PSA = new(3, "Professional Sports Authenticator", "PSA", @"https://www.psacard.com/cert/");
    public static readonly AuthenticationCompanies Radke = new(11, "Radke");
    public static readonly AuthenticationCompanies Steiner = new(5, "Steiner");
    public static readonly AuthenticationCompanies TriStar = new(6, "TriStar");
    public static readonly AuthenticationCompanies USASportsMarketing = new(18, "USA Sports Marketing", "USA");

    public string WebsitePath { get; set; }

    public static readonly AuthenticationCompanies[] All =
    [
        Beckett,
        Fanatics,
        JSA,
        Leaf,
        MAB,
        MajorLeagueBaseball,
        Other,
        Player,
        PSA,
        Radke,
        Steiner,
        TriStar,
        USASportsMarketing
    ];

    public static readonly AuthenticationCompanies[] BigThree =
    [
        Beckett,
        JSA,
        PSA
    ];

    public static readonly AuthenticationCompanies[] Navigatable =
    [
        JSA,
        PSA
    ];

    private AuthenticationCompanies(int id, 
                                  string name, 
                                  string abbreviation = null, 
                                  string websitePath = null) 
        : base(id, name, abbreviation) 
    {
        WebsitePath = websitePath;
    }

    public static AuthenticationCompanies Find(int id)
        => All.SingleOrDefault(authenticationCompany => authenticationCompany.Id == id);
}

namespace Memorabilia.Domain.Constants;

public sealed class JerseyStyleTypes : DomainItemConstants
{
    public static readonly JerseyStyleTypes AllStar = new(5, "All Star");
    public static readonly JerseyStyleTypes Alternate = new(3, "Alternate");
    public static readonly JerseyStyleTypes Away = new(2, "Away");
    public static readonly JerseyStyleTypes Finals = new(7, "Finals");
    public static readonly JerseyStyleTypes Home = new(1, "Home");
    public static readonly JerseyStyleTypes None = new(15, "None");
    public static readonly JerseyStyleTypes Other = new(9, "Other");
    public static readonly JerseyStyleTypes ProBowl = new(6, "Pro Bowl");
    public static readonly JerseyStyleTypes SuperBowl = new(14, "Super Bowl");
    public static readonly JerseyStyleTypes TeamUSA = new(13, "Team USA", "USA");
    public static readonly JerseyStyleTypes Throwback = new(8, "Throwback");
    public static readonly JerseyStyleTypes Unknown = new(10, "Unknown");
    public static readonly JerseyStyleTypes WorldSeries = new(4, "World Series");    

    public static readonly JerseyStyleTypes[] All =
    [
        AllStar,
        Alternate,
        Away,
        Finals,
        Home,
        None,
        Other,
        ProBowl,
        SuperBowl,
        TeamUSA,
        Throwback,
        Unknown,        
        WorldSeries
    ];

    private JerseyStyleTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static JerseyStyleTypes Find(int id)
        => All.SingleOrDefault(jerseyStyleType => jerseyStyleType.Id == id);
}

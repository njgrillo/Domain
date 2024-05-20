namespace Memorabilia.Domain.Constants;

public sealed class ProjectTypes : DomainItemConstants
{
    public static readonly ProjectTypes BaseballType = new(1, "Baseball Type", "A project based on a baseball type.");
    public static readonly ProjectTypes Card = new(2, "Card", "A project based on a card set.");
    public static readonly ProjectTypes HallOfFame = new(3, "Hall of Fame", "A project based on Hall of Famers.");
    public static readonly ProjectTypes HelmetType = new(4, "Helmet Type", "A project based on a helmet type.");
    public static readonly ProjectTypes ItemType = new(5, "Item Type", "A project based on an item type.");
    public static readonly ProjectTypes MultiSignedItemType = new(6, "Multi Signed Item Type", "A project based on an item type signed by multiple people.");
    public static readonly ProjectTypes Team = new(7, "Team", "A project based on a team.");
    public static readonly ProjectTypes WorldSeries = new(8, "World Series", "A project based on a World Series.");

    public static readonly ProjectTypes[] All =
    [
        BaseballType,
        Card,
        HallOfFame,
        HelmetType,
        ItemType,
        MultiSignedItemType,
        Team,
        WorldSeries
    ];

    public static readonly ProjectTypes[] PersonProject =
    [
        BaseballType,
        Card,
        HallOfFame,
        ItemType,
        Team,
        WorldSeries
    ];

    public static readonly ProjectTypes[] TeamProject =
    [
        HelmetType
    ];

    private ProjectTypes(int id, string name, string description, string abbreviation = null) 
        : base(id, name, abbreviation) 
    { 
        Description = description;
    }

    public string Description { get; set; }

    public override string ToString()
        => Name.Replace(" ", "");

    public static ProjectTypes Find(int id)
        => All.SingleOrDefault(projectType => projectType.Id == id);    

    public static bool IsPersonProject(ProjectTypes projectType)
        => PersonProject.Contains(projectType);

    public static bool IsTeamProject(ProjectTypes projectType)
        => TeamProject.Contains(projectType);
}

namespace Memorabilia.Domain.Constants;

public sealed class ProjectStatusTypes : DomainItemConstants
{
    public static readonly ProjectStatusTypes Completed = new(1, "Completed");
    public static readonly ProjectStatusTypes InProgress = new(2, "In Progress");
    public static readonly ProjectStatusTypes NotStarted = new(3, "Not Started");

    public static readonly ProjectStatusTypes[] All =
    [
        Completed,
        InProgress, 
        NotStarted
    ];

    private ProjectStatusTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static ProjectStatusTypes Find(int id)
        => All.SingleOrDefault(projectStatusType => projectStatusType.Id == id);
}

namespace Memorabilia.Domain.Constants;

public class ProjectSteps : DomainItemConstants
{
    public static readonly ProjectSteps General = new(2, "General Information");
    public static readonly ProjectSteps ProjectDetail = new(3, "Project Details");
    public static readonly ProjectSteps ProjectType = new(1, "Project Type");   
    
    public static readonly ProjectSteps[] All =
    [
       General,
       ProjectDetail,
       ProjectType
    ];

    private ProjectSteps(int id, string name)
        : base(id, name) { }

    public static ProjectSteps Find(int id)
        => All.SingleOrDefault(projectStep => projectStep.Id == id);
}

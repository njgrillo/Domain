namespace Memorabilia.Domain.Constants;

public sealed class TeamSteps : DomainItemConstants
{
    public static readonly TeamSteps Championship = new(5, "Championships");
    public static readonly TeamSteps Conference = new(3, "Conferences");
    public static readonly TeamSteps Division = new(2, "Divisions");       
    public static readonly TeamSteps League = new(4, "Leagues");       
    public static readonly TeamSteps Team = new(1, "Team");

    public static readonly TeamSteps[] All =
    [
       Championship,
       Conference,
       Division,
       League,
       Team
    ];

    private TeamSteps(int id, string name) 
        : base(id, name) { }

    public static TeamSteps Find(int id)
        => All.SingleOrDefault(teamStep => teamStep.Id == id);
}

namespace Memorabilia.Domain.Constants;

public sealed class PersonSteps : DomainItemConstants
{
    public static readonly PersonSteps Accolade = new(5, "Accolades");
    public static readonly PersonSteps HallOfFame = new(6, "Hall Of Fames");
    public static readonly PersonSteps Image = new(7, "Image");
    public static readonly PersonSteps Occupation = new(2, "Occupations");
    public static readonly PersonSteps Person = new(1, "Person");
    public static readonly PersonSteps SportService = new(3, "Sport Service");
    public static readonly PersonSteps Team = new(4, "Teams");

    public static readonly PersonSteps[] All =
    [
       Accolade,
       HallOfFame,
       Image,
       Occupation,
       Person,
       SportService,
       Team
    ];

    private PersonSteps(int id, string name) 
        : base(id, name) { }

    public static PersonSteps Find(int id)
        => All.SingleOrDefault(personStep => personStep.Id == id);
}

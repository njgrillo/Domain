namespace Memorabilia.Domain.Constants;

public sealed class AutographSteps : DomainItemConstants
{
    public static readonly AutographSteps Autograph = new(1, "Autograph");
    public static readonly AutographSteps Authentication = new(3, "Authentications");        
    public static readonly AutographSteps Image = new(5, "Images");
    public static readonly AutographSteps Inscription = new(2, "Inscriptions");
    public static readonly AutographSteps Spot = new(4, "Spot");

    public static readonly AutographSteps[] All =
    [
       Autograph,
       Authentication,
       Image,
       Inscription,
       Spot
    ];

    private AutographSteps(int id, string name) 
        : base(id, name) { }

    public static AutographSteps Find(int id)
        => All.SingleOrDefault(autographStep => autographStep.Id == id);
}

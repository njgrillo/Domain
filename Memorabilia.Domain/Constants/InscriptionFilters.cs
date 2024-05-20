namespace Memorabilia.Domain.Constants;

public sealed class InscriptionFilters : Filters<InscriptionFilters>
{
    public static readonly InscriptionFilters None = new("None");
    public static readonly InscriptionFilters NoInscription = new("No Inscriptions(s)");
    public static readonly InscriptionFilters Inscription = new("Has Inscriptions(s)");

    private InscriptionFilters(string name) 
        : base(name) { }

    public static readonly InscriptionFilters[] All =
    [
        None,
        NoInscription,
        Inscription
    ];

    public static readonly InscriptionFilters[] FilterItems =
    [
        NoInscription,
        Inscription
    ];
}

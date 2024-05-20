namespace Memorabilia.Domain.Constants;

public sealed class PersonalizationFilters : Filters<PersonalizationFilters>
{
	public static readonly PersonalizationFilters None = new("None");
    public static readonly PersonalizationFilters NotPersonalized = new("Not Personalized");
    public static readonly PersonalizationFilters Personalized = new("Personalized");

    private PersonalizationFilters(string name) 
        : base(name) { }

    public static readonly PersonalizationFilters[] All =
    [
        None,
        NotPersonalized,
        Personalized
    ];

    public static readonly PersonalizationFilters[] FilterItems =
    [
        NotPersonalized,
        Personalized
    ];
}

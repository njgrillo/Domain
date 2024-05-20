namespace Memorabilia.Domain.Constants;

public class AutographFilters : Filters<AutographFilters>
{
    public static readonly AutographFilters None = new("None");
    public static readonly AutographFilters WithAutographs = new("w/ Auto(s)");
    public static readonly AutographFilters WithoutAutographs = new("w/o Auto(s)");

    private AutographFilters(string name)
        : base(name) { }

    public static readonly AutographFilters[] All =
    [
        None,
        WithAutographs,
        WithoutAutographs
    ];

    public static readonly AutographFilters[] FilterItems =
    [
        WithAutographs,
        WithoutAutographs
    ];
}

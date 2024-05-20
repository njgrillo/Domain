namespace Memorabilia.Domain.Constants;

public sealed class OccupationTypes : DomainItemConstants
{
    public static readonly OccupationTypes Primary = new(1, "Primary");
    public static readonly OccupationTypes Secondary = new(2, "Secondary");

    public static readonly OccupationTypes[] All =
    [
        Primary,
        Secondary
    ];

    private OccupationTypes(int id, string name)
        : base(id, name) { }

    public static OccupationTypes Find(int id)
        => All.SingleOrDefault(occupationType => occupationType.Id == id);
}

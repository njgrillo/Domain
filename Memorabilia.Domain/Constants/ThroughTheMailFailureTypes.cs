namespace Memorabilia.Domain.Constants;

public sealed class ThroughTheMailFailureTypes : DomainItemConstants
{
    public static readonly ThroughTheMailFailureTypes IncorrectAddress = new(1, "Incorrect Address");
    public static readonly ThroughTheMailFailureTypes RefusedToSign = new(2, "Refused to Sign");
    public static readonly ThroughTheMailFailureTypes RequestedFee = new(3, "Requested Fee/Donation");

    public static readonly ThroughTheMailFailureTypes[] All =
    [
        IncorrectAddress,
        RefusedToSign,
        RequestedFee
    ];

    private ThroughTheMailFailureTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static ThroughTheMailFailureTypes Find(int id)
        => All.SingleOrDefault(type => type.Id == id);

    public static ThroughTheMailFailureTypes Find(string name)
        => All.SingleOrDefault(type => type.Name == name);
}

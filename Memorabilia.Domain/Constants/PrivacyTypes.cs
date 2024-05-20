namespace Memorabilia.Domain.Constants;

public sealed class PrivacyTypes : DomainItemConstants
{
    public static readonly PrivacyTypes Public = new(1, "Public");
    public static readonly PrivacyTypes Private = new(2, "Private");

    public static readonly PrivacyTypes[] All =
    [
        Public,
        Private
    ];

    private PrivacyTypes(int id, string name) 
        : base(id, name) { }

    public static PrivacyTypes Find(int id)
        => All.SingleOrDefault(privacyType => privacyType.Id == id);
}

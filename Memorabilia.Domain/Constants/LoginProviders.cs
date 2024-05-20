namespace Memorabilia.Domain.Constants;

public sealed class LoginProviders : DomainItemConstants
{
    public static readonly LoginProviders Google = new(1, "Google");
    public static readonly LoginProviders Meta = new(2, "Meta", "Facebook");
    public static readonly LoginProviders Microsoft = new(3, "Microsoft");
    public static readonly LoginProviders X = new(4, "X", "Twitter");

    public static readonly LoginProviders[] All =
    [
        Google,
        Meta,
        Microsoft,
        X
    ];

    public string LegacyName { get; private set; }

    public string LoginPageName { get; private set; }

    private LoginProviders(int id, string name, string legacyName = null, string abbreviation = null)
        : base(id, name, abbreviation) 
    {
        LegacyName = legacyName;
    }

    public static LoginProviders Find(int id)
        => All.SingleOrDefault(LoginProviders => LoginProviders.Id == id);

    public static LoginProviders Find(string name)
        => All.SingleOrDefault(LoginProviders => LoginProviders.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
                                             || (!LoginProviders.LegacyName.IsNullOrEmpty() && LoginProviders.LegacyName.Equals(name, StringComparison.OrdinalIgnoreCase)));
}

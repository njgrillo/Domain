namespace Memorabilia.Domain.Constants;

public sealed class AuthenticationFilters : Filters<AuthenticationFilters>
{
    public static readonly AuthenticationFilters None = new("None");
    public static readonly AuthenticationFilters NotAuthenticated = new("Not Authenticated");
    public static readonly AuthenticationFilters Authenticated = new("Authenticated");

    private AuthenticationFilters(string name)
        : base(name) { }

    public static readonly AuthenticationFilters[] All =
    [
        None,
        NotAuthenticated,
        Authenticated
    ];

    public static readonly AuthenticationFilters[] FilterItems =
    [
        NotAuthenticated,
        Authenticated
    ];
}

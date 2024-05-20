namespace Memorabilia.Domain.Constants;

public sealed class ProfileTypes
{
    public static readonly ProfileTypes Baseball = new ("Baseball");
    public static readonly ProfileTypes Basketball = new ("Basketball");
    public static readonly ProfileTypes Football = new ("Football");

    public static readonly ProfileTypes[] All =
    [
        Baseball,
        Basketball,
        Football
    ];

    private ProfileTypes(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

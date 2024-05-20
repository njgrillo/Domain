namespace Memorabilia.Domain.Constants;

public sealed class SocialMediaTypes : DomainItemConstants
{
    public static readonly SocialMediaTypes Instagram = new(3, "Instagram");
    public static readonly SocialMediaTypes Meta = new(1, "Meta");
    public static readonly SocialMediaTypes TikTok = new(6, "TikTok");
    public static readonly SocialMediaTypes Truth = new(5, "Truth");
    public static readonly SocialMediaTypes X = new(2, "X");
    public static readonly SocialMediaTypes YouTube = new(4, "YouTube");

    public static readonly SocialMediaTypes[] All =
    [
        Instagram,
        Meta,
        TikTok,
        Truth,
        X,
        YouTube
    ];

    private SocialMediaTypes(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static SocialMediaTypes Find(int id)
        => All.SingleOrDefault(socialMediaType => socialMediaType.Id == id);
}

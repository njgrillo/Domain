namespace Memorabilia.Domain.Constants;

public sealed class ImageTypes : DomainItemConstants
{
    public static readonly ImageTypes Primary = new(1, "Primary");
    public static readonly ImageTypes Secondary = new(2, "Secondary");

    public static readonly ImageTypes[] All =
    [
        Primary,
        Secondary
    ];

    private ImageTypes(int id, string name) 
        : base(id, name) { }

    public static ImageTypes Find(int id)
        => All.SingleOrDefault(imageType => imageType.Id == id);
}

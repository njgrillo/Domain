namespace Memorabilia.Domain.Constants;

public sealed class ImageFilters : Filters<ImageFilters>
{
    public static readonly ImageFilters None = new("None");
    public static readonly ImageFilters NoImages = new("No Images(s)");
    public static readonly ImageFilters Images = new("Image(s)");

    private ImageFilters(string name) 
        : base(name) { }

    public static readonly ImageFilters[] All =
    [
        None,
        NoImages,
        Images
    ];

    public static readonly ImageFilters[] FilterItems =
    [
        NoImages,
        Images
    ];
}

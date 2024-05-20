namespace Memorabilia.Domain.Constants;

public sealed class HelmetFinishes : DomainItemConstants
{
    public static readonly HelmetFinishes Blaze = new(6, "Blaze");
    public static readonly HelmetFinishes Bronze = new(5, "Bronze");
    public static readonly HelmetFinishes Chrome = new(2, "Chrome");
    public static readonly HelmetFinishes ChromeTwentyFourKaratGoldPlatedFacemask = new(15, "Chrome 24k Gold Plated Facemask");
    public static readonly HelmetFinishes Copper = new(14, "Copper");
    public static readonly HelmetFinishes Custom = new(9, "Custom");
    public static readonly HelmetFinishes Drip = new(10, "Drip");
    public static readonly HelmetFinishes Flash = new(7, "Flash");
    public static readonly HelmetFinishes Hydro = new(13, "Hydro");
    public static readonly HelmetFinishes Ice = new(8, "Ice");
    public static readonly HelmetFinishes Other = new(12, "Other");
    public static readonly HelmetFinishes Pewter = new(1, "Pewter");
    public static readonly HelmetFinishes Ripped = new(11, "Ripped");
    public static readonly HelmetFinishes SterlingSilver = new(4, "Sterling Silver");
    public static readonly HelmetFinishes TwentyFourKaratGoldPlated = new(3, "24k Gold Plated");

    public static readonly HelmetFinishes[] All =
    [
        Blaze,
        Bronze,
        Chrome,
        ChromeTwentyFourKaratGoldPlatedFacemask,
        Copper,
        Custom,
        Drip,
        Flash,
        Hydro,
        Ice,
        Other,
        Pewter,
        Ripped,
        SterlingSilver,
        TwentyFourKaratGoldPlated
    ];

    public static readonly HelmetFinishes[] Project =
    [
        Pewter
    ];

    private HelmetFinishes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static HelmetFinishes Find(int id)
        => All.SingleOrDefault(helmetFinish => helmetFinish.Id == id);
}

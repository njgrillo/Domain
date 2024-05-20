namespace Memorabilia.Domain.Constants;

public sealed class WritingInstruments : DomainItemConstants
{
    public static readonly WritingInstruments BallpointPen = new(1, "Ballpoint Pen");
    public static readonly WritingInstruments Other = new(6, "Other");
    public static readonly WritingInstruments PaintPen = new(2, "Paint Pen");
    public static readonly WritingInstruments Sharpie = new(3, "Sharpie");
    public static readonly WritingInstruments Unknown = new(7, "Unknown");

    public static readonly WritingInstruments[] All =
    [
        BallpointPen,
        Other,
        PaintPen,
        Sharpie,
        Unknown
    ];

    private WritingInstruments(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static WritingInstruments Find(int id)
        => All.SingleOrDefault(writingInstrument => writingInstrument.Id == id);

    public static WritingInstruments Find(string name)
        => All.SingleOrDefault(writingInstrument => writingInstrument.Name == name);
}

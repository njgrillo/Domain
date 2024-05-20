namespace Memorabilia.Domain.Constants;

public sealed class FigureSpecialtyTypes : DomainItemConstants
{
    public static readonly FigureSpecialtyTypes ClassicDoubles = new(1, "Classic Doubles");
    public static readonly FigureSpecialtyTypes CooperstownCollection = new(2, "Cooperstown Collection");
    public static readonly FigureSpecialtyTypes None = new(9, "None");
    public static readonly FigureSpecialtyTypes Other = new(8, "Other");
    public static readonly FigureSpecialtyTypes Unknown = new(7, "Unknown");

    public static readonly FigureSpecialtyTypes[] All =
    [
        ClassicDoubles,
        CooperstownCollection,
        None,
        Other,
        Unknown
    ];

    public static readonly FigureSpecialtyTypes[] FunkoPops =
    [
        
    ];

    public static readonly FigureSpecialtyTypes[] StartingLineups =
    [
        ClassicDoubles,
        CooperstownCollection
    ];

    private FigureSpecialtyTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static FigureSpecialtyTypes Find(int id)
        => All.SingleOrDefault(figureSpecialtyType => figureSpecialtyType.Id == id);

    public static FigureSpecialtyTypes[] GetAll(FigureTypes figureType)
    {
        if (figureType == FigureTypes.StartingLineup)
            return StartingLineups;

        if (figureType == FigureTypes.FunkoPop)
            return FunkoPops;

        return All;
    }
}

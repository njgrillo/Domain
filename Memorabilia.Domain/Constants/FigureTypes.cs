namespace Memorabilia.Domain.Constants;

public sealed class FigureTypes : DomainItemConstants
{    
    public static readonly FigureTypes FunkoPop = new(2, "Funko Pop");
    public static readonly FigureTypes None = new(8, "None");
    public static readonly FigureTypes Other = new(7, "Other");
    public static readonly FigureTypes StartingLineup = new(1, "Starting Lineup", "SLU");
    public static readonly FigureTypes Unknown = new(6, "Unknown");

    public static readonly FigureTypes[] All =
    [        
        FunkoPop,
        None,
        Other,
        StartingLineup,
        Unknown
    ];

    private FigureTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static FigureTypes Find(int id)
        => All.SingleOrDefault(figureType => figureType.Id == id);
}

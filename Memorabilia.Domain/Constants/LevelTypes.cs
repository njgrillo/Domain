namespace Memorabilia.Domain.Constants;

public sealed class LevelTypes : DomainItemConstants
{
    public static readonly LevelTypes College = new(1, "College");
    public static readonly LevelTypes HighSchool = new(2, "High School");
    public static readonly LevelTypes Professional = new(3, "Professional");
    public static readonly LevelTypes Amateur = new(4, "Amateur");
    public static readonly LevelTypes Other = new(5, "Other");
    public static readonly LevelTypes None = new(6, "None");
    public static readonly LevelTypes Unknown = new(7, "Unknown");
    public static readonly LevelTypes TripleA = new(8, "Triple A", "AAA");
    public static readonly LevelTypes DoubleA = new(9, "Double A", "AA");
    public static readonly LevelTypes HighClassA = new(10, "High Class A", "A+");
    public static readonly LevelTypes ClassA = new(11, "Class A", "A");
    public static readonly LevelTypes Rookie = new(12, "Rookie");

    public static readonly LevelTypes[] All =
    [
        Amateur,
        ClassA,
        College,
        DoubleA,
        HighClassA,
        HighSchool,
        None,
        Other,
        Professional,
        Rookie,
        TripleA,
        Unknown
    ];

    private LevelTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static LevelTypes Find(int id)
        => All.SingleOrDefault(LevelTypes => LevelTypes.Id == id);
}

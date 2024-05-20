namespace Memorabilia.Domain.Constants;

public sealed class InscriptionTypes : DomainItemConstants
{
    public static readonly InscriptionTypes Accomplishment = new(10, "Accomplishment"); 
    public static readonly InscriptionTypes Award = new(11, "Award");
    public static readonly InscriptionTypes BibleVerse = new(6, "Bible Verse");
    public static readonly InscriptionTypes Championship = new(13, "Championship");
    public static readonly InscriptionTypes Draft = new(15, "Draft");
    public static readonly InscriptionTypes Greeting = new(8, "Greeting");
    public static readonly InscriptionTypes HallOfFame = new(1, "Hall of Fame", "HOF");
    public static readonly InscriptionTypes Nickname = new(12, "Nickname");
    public static readonly InscriptionTypes Number = new(3, "Number");
    public static readonly InscriptionTypes Other = new(18, "Other");
    public static readonly InscriptionTypes Statistic = new(9, "Statistic", "STAT");
    public static readonly InscriptionTypes Team = new(14, "Team");             

    public static readonly InscriptionTypes[] All =
    [
        Accomplishment,
        Award,
        BibleVerse,
        Championship,
        Draft,
        Greeting,
        HallOfFame,
        Nickname,
        Number,
        Other,
        Statistic,
        Team
    ];

    private InscriptionTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static InscriptionTypes Find(int id)
        => All.SingleOrDefault(inscriptionType => inscriptionType.Id == id);
}

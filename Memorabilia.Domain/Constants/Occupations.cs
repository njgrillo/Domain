namespace Memorabilia.Domain.Constants;

public sealed class Occupations : DomainItemConstants
{       
    public static readonly Occupations Actor = new(2, "Actor");
    public static readonly Occupations Actress = new(3, "Actress");
    public static readonly Occupations Administrator = new(20, "Administrator");
    public static readonly Occupations Announcer = new(24, "Announcer");
    public static readonly Occupations Astronaut = new(19, "Astronaut");
    public static readonly Occupations Athlete = new(1, "Athlete");
    public static readonly Occupations Broadcaster = new(5, "Broadcaster");
    public static readonly Occupations Celebrity = new(4, "Celebrity");
    public static readonly Occupations Coach = new(9, "Coach");
    public static readonly Occupations Comedian = new(6, "Comedian");
    public static readonly Occupations Commissioner = new(8, "Commissioner");        
    public static readonly Occupations Executive = new(15, "Executive");        
    public static readonly Occupations FamousRelative = new(22, "Famous Relative");        
    public static readonly Occupations GeneralManager = new(14, "General Manager");        
    public static readonly Occupations Historian = new(27, "Historian");        
    public static readonly Occupations LeaguePresident = new(12, "League President");       
    public static readonly Occupations Manager = new(7, "Manager");       
    public static readonly Occupations Musician = new(18, "Musician");
    public static readonly Occupations Owner = new(13, "Owner");
    public static readonly Occupations Podcaster = new(29, "Podcaster");
    public static readonly Occupations Politician = new(16, "Politician");
    public static readonly Occupations President = new(17, "President");  
    public static readonly Occupations Singer = new(28, "Singer");  
    public static readonly Occupations SportsWriter = new(23, "Sports Writer");  
    public static readonly Occupations Statistician = new(25, "Statistician");  
    public static readonly Occupations Trainer = new(26, "Trainer");  
    public static readonly Occupations Umpire = new(21, "Umpire");  

    public static readonly Occupations[] All =
    [
        Actor,
        Actress,
        Administrator,
        Announcer,
        Astronaut,
        Athlete,
        Broadcaster,
        Celebrity,  
        Coach,
        Comedian,
        Commissioner,
        Executive,
        FamousRelative,
        GeneralManager,
        Historian,
        LeaguePresident,
        Manager,
        Musician,
        Owner,
        Podcaster,
        Politician,
        President,
        Singer,
        SportsWriter,
        Statistician,
        Trainer,
        Umpire
    ];

    public static Occupations[] BaseballOccupationss
        => SportOccupationss.Union([LeaguePresident, Manager, Umpire])
                           .ToArray();

    public static readonly Occupations[] SportOccupationss =
    [
        Administrator,
        Announcer,
        Athlete,
        Broadcaster,
        Coach,
        Commissioner,
        Executive,
        FamousRelative,
        GeneralManager,
        Historian,
        Owner,
        SportsWriter,
        Statistician,
        Trainer
    ];

    private Occupations(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static Occupations Find(int id)
        => All.SingleOrDefault(Occupations => Occupations.Id == id);

    public static bool IsBaseballOccupations(int id)
        => BaseballOccupationss.Contains(Find(id));

    public static bool IsSportOccupations(int id)
        => SportOccupationss.Contains(Find(id));
}

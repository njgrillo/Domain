namespace Memorabilia.Domain.Constants;

public sealed class Positions : DomainItemConstants
{
    public static readonly Positions Back = new(33, "Back");
    public static readonly Positions BasketballCenter = new(40, "Center");
    public static readonly Positions BasketballGuard = new(42, "Guard");
    public static readonly Positions BlockingBack = new (34, "Blocking Back");
    public static readonly Positions Catcher = new(2, "Catcher", "C");    
    public static readonly Positions CenterField = new(7, "Center Field", "CF");
    public static readonly Positions Cornerback = new(21, "Cornerback", "CB");
    public static readonly Positions DefensiveEnd = new(19, "Defensive End", "DE");
    public static readonly Positions DefensiveTackle = new(24, "Defensive Tackle", "DT");
    public static readonly Positions DesignatedHitter = new(10, "Designated Hitter", "DH");
    public static readonly Positions End = new(30, "End");
    public static readonly Positions FirstBase = new(3, "First Base", "1B");
    public static readonly Positions Flanker = new(36, "Flanker");
    public static readonly Positions FootballCenter = new(22, "Center", "C");
    public static readonly Positions FootballGuard = new(18, "Guard", "G");
    public static readonly Positions Forward = new(43, "Forward");
    public static readonly Positions Fullback = new(17, "Fullback", "FB");    
    public static readonly Positions Halfback = new(16, "Halfback", "HB");
    public static readonly Positions Infielder = new(32, "Infielder", "IF");
    public static readonly Positions Kicker = new(27, "Kicker", "K");
    public static readonly Positions LeftField = new(8, "Left Field", "LF");
    public static readonly Positions Linebacker = new(28, "Linebacker");
    public static readonly Positions LongSnapper = new(25, "Long Snapper");
    public static readonly Positions OffensiveTackle = new (23, "Offensive Tackle", "OT");
    public static readonly Positions Outfielder = new (29, "Outfielder");
    public static readonly Positions Pitcher = new(1, "Pitcher", "P");
    public static readonly Positions PointGuard = new (39, "Point Guard");
    public static readonly Positions PowerForward = new (41, "Power Forward");
    public static readonly Positions Punter = new(26, "Punter", "P");
    public static readonly Positions Quarterback = new(12, "Quarterback", "QB");
    public static readonly Positions ReturnSpecialist = new(35, "Return Specialist");
    public static readonly Positions RightField = new(9, "Right Field", "RF");    
    public static readonly Positions Runningback = new(13, "Running back", "RB");
    public static readonly Positions Safety = new(20, "Safety", "S");
    public static readonly Positions SecondBase = new(4, "Second Base", "2B");
    public static readonly Positions ShootingGuard = new (38, "Shooting Guard");
    public static readonly Positions Shortstop = new(5, "Shortstop", "SS");
    public static readonly Positions SmallForward = new (37, "Small Forward");
    public static readonly Positions SpecialTeamer = new (44, "Special Teamer");
    public static readonly Positions SplitEnd = new (31, "Split End");
    public static readonly Positions Tailback = new(45, "Tailback");
    public static readonly Positions ThirdBase = new(6, "Third Base", "3B");
    public static readonly Positions TightEnd = new(15, "Tight End", "TE");
    public static readonly Positions Utility = new(11, "Utility", "U");
    public static readonly Positions WideReceiver = new(14, "Wide Receiver", "WR");

    public static Positions[] All
        => Baseball.Union(Basketball)
                   .Union(Football)
                   .Distinct()
                   .ToArray();

    public static readonly Positions[] Baseball =
    [
        Catcher,
        CenterField,
        DesignatedHitter,
        FirstBase,
        Infielder,
        LeftField,
        Outfielder,
        Pitcher,
        RightField,
        SecondBase,
        Shortstop,
        ThirdBase,
        Utility
    ];

    public static readonly Positions[] Basketball =
    [
        BasketballCenter,
        BasketballGuard,
        Forward,
        PointGuard,
        PowerForward,
        ShootingGuard,
        SmallForward
    ];

    public static readonly Positions[] Football =
    [
        Back,
        BlockingBack,
        Cornerback,
        DefensiveEnd,
        DefensiveTackle,
        End,
        Flanker,
        FootballCenter,
        FootballGuard,
        Fullback,
        Halfback,
        Kicker,
        Linebacker,
        LongSnapper,
        OffensiveTackle,
        Punter,
        Quarterback,
        ReturnSpecialist,
        Runningback,
        Safety,
        SpecialTeamer,
        SplitEnd,
        Tailback,
        TightEnd,
        WideReceiver
    ];

    private Positions(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Positions Find(int id)
        => All.SingleOrDefault(Positions => Positions.Id == id);

    public static Positions[] GetAll(params Sports[] sports)
    {
        if (sports.IsNullOrEmpty())
            return All;

        var Positionss = new List<Positions>();

        if (sports.Any(sport => sport == Sports.Baseball))
            Positionss.AddRange(Baseball);

        if (sports.Any(sport => sport == Sports.Basketball))
            Positionss.AddRange(Basketball);

        if (sports.Any(sport => sport == Sports.Football))
            Positionss.AddRange(Football);

        return Positionss.OrderBy(Positions => Positions.Name).ToArray();
    }
}

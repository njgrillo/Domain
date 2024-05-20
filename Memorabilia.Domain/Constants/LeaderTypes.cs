namespace Memorabilia.Domain.Constants;

public sealed class LeaderTypes : DomainItemConstants
{
    public static readonly LeaderTypes AAFCReceivingYards = new(61, "AAFC Receiving Yards");
    public static readonly LeaderTypes AAFCReceptions = new(62, "AAFC Receptions");
    public static readonly LeaderTypes AAFCRushingTouchdowns = new(65, "AAFC Rushing Touchdowns");
    public static readonly LeaderTypes AAFCRushingYards = new(64, "AAFC Rushing Yards");
    public static readonly LeaderTypes ABAScoringChampion = new (77, "ABA Scoring Champion");
    public static readonly LeaderTypes ABLScoring = new (73, "ABL Scoring");
    public static readonly LeaderTypes AFLCompletionPercentage = new(58, "AFL Completion Percentage");
    public static readonly LeaderTypes AFLInterceptions = new(67, "AFL Interceptions");
    public static readonly LeaderTypes AFLPasserRating = new(57, "AFL Passer Rating");
    public static readonly LeaderTypes AFLPassingTouchdowns = new(54, "AFL Passing Touchdowns");
    public static readonly LeaderTypes AFLPassingYards = new(53, "AFL Passing Yards");
    public static readonly LeaderTypes AFLReceivingTouchdowns = new(42, "AFL Receiving Touchdowns");
    public static readonly LeaderTypes AFLReceivingYards = new(40, "AFL Receiving Yards");
    public static readonly LeaderTypes AFLReceptions = new(41, "AFL Receptions");
    public static readonly LeaderTypes AmericanLeagueBattingChampion = new(1, "American League Batting Champion", "AL Batting Champ");
    public static readonly LeaderTypes AmericanLeagueEarnedRunAverageLeader = new(11, "American League Earned Run Average Leader", "AL ERA Leader");
    public static readonly LeaderTypes AmericanLeagueHitsLeader = new(18, "American League Hits Leader", "AL Hits Leader");
    public static readonly LeaderTypes AmericanLeagueHomeRunLeader = new(2, "American League Home Run Leader", "AL HR Leader");
    public static readonly LeaderTypes AmericanLeagueRunBattedInLeader = new(3, "American League Run Batted In Leader", "AL RBI Leader");
    public static readonly LeaderTypes AmericanLeagueRunsLeader = new(29, "American League Runs Leader", "AL Runs Leader");
    public static readonly LeaderTypes AmericanLeagueSavesLeader = new(24, "American League Saves Leader", "AL Saves Leader");
    public static readonly LeaderTypes AmericanLeagueStolenBaseLeader = new(7, "American League Stolen Base Leader", "AL Stolen Base Leader");
    public static readonly LeaderTypes AmericanLeagueStrikeoutLeader = new(13, "American League Strikeout Leader", "AL Strikeout Leader");
    public static readonly LeaderTypes AmericanLeagueTriplesLeader = new(26, "American League Triples Leader", "AL Triples Leader");
    public static readonly LeaderTypes AmericanLeagueWinsLeader = new(15, "American League Wins Leader", "AL Wins Leader");
    public static readonly LeaderTypes BAAScoringChampion = new (75, "BAA Scoring Champion");    
    public static readonly LeaderTypes CompletionPercentage = new (36, "NFL Completion Percentage");    
    public static readonly LeaderTypes ForcedFumbles = new (60, "NFL Forced Fumbles");    
    public static readonly LeaderTypes Interceptions = new (43, "NFL Interceptions");    
    public static readonly LeaderTypes KickoffReturnYards = new (56, "NFL Kickoff Return Yards");    
    public static readonly LeaderTypes MajorLeagueBaseballBattingChampion = new(32, "Major League Baseball Batting Champion", "MLB Batting Champ");
    public static readonly LeaderTypes MajorLeagueBaseballEarnedRunAverageLeader = new(23, "Major League Baseball Earned Run Average Leader", "MLB ERA Leader");
    public static readonly LeaderTypes MajorLeagueBaseballHitsLeader = new(20, "Major League Baseball Hits Leader", "MLB Hits Leader");
    public static readonly LeaderTypes MajorLeagueBaseballHomeRunLeader = new(9, "Major League Baseball Home Run Leader", "MLB HR Leader");
    public static readonly LeaderTypes MajorLeagueBaseballRunsBattedInLeader = new(17, "Major League Baseball Runs Batted In Leader", "MLB RBI Leader");
    public static readonly LeaderTypes MajorLeagueBaseballRunsLeader = new(31, "Major League Baseball Runs Leader", "MLB Runs Leader");
    public static readonly LeaderTypes MajorLeagueBaseballSavesLeader = new(22, "Major League Baseball Saves Leader", "MLB Saves Leader");
    public static readonly LeaderTypes MajorLeagueBaseballStolenBaseLeader = new (33, "Major League Baseball Stolen Base Leader", "MLB Stolen Base Leader");
    public static readonly LeaderTypes MajorLeagueBaseballStrikeoutLeader = new(21, "Major League Baseball Strikeout Leader", "MLB Strikeout Leader");
    public static readonly LeaderTypes MajorLeagueBaseballTriplesLeader = new(28, "Major League Baseball Triples Leader", "MLB Triples Leader");
    public static readonly LeaderTypes MajorLeagueBaseballWinsLeader = new(10, "Major League Baseball Wins Leader", "MLB Wins Leader");
    public static readonly LeaderTypes NationalLeagueAssists = new(55, "National League Assists", "NL Assists");
    public static readonly LeaderTypes NationalLeagueBattingChampion = new(4, "National League Batting Champion", "NL Batting Champ");
    public static readonly LeaderTypes NationalLeagueHitsLeader = new(19, "National League Hits Leader", "NL Hits Leader");
    public static readonly LeaderTypes NationalLeagueEarnedRunAverageLeader = new(12, "National League Earned Run Average Leader", "NL ERA Leader");
    public static readonly LeaderTypes NationalLeagueHomeRunLeader = new(5, "National League Home Run Leader", "NL HR Leader");
    public static readonly LeaderTypes NationalLeagueRunBattedInLeader = new(6, "National League Run Batted In Leader", "NL RBI Leader");
    public static readonly LeaderTypes NationalLeagueRunsLeader = new(30, "National League Runs Leader", "NL Runs Leader");
    public static readonly LeaderTypes NationalLeagueSavesLeader = new(25, "National League Saves Leader", "NL Saves Leader");
    public static readonly LeaderTypes NationalLeagueStolenBaseLeader = new(8, "National League Stolen Base Leader", "NL Stolen Base Leader");
    public static readonly LeaderTypes NationalLeagueStrikeoutLeader = new(14, "National League Strikeout Leader", "NL Strikeout Leader");
    public static readonly LeaderTypes NationalLeagueTriplesLeader = new(27, "National League Triples Leader", "NL Triples Leader");
    public static readonly LeaderTypes NationalLeagueWinsLeader = new(16, "National League Wins Leader", "NL Wins Leader");
    public static readonly LeaderTypes NBAAssists = new(74, "NBA Assists");
    public static readonly LeaderTypes NBABlocks = new(78, "NBA Blocks");
    public static readonly LeaderTypes NBAReboundingLeader = new(71, "NBA Rebounding Leader");
    public static readonly LeaderTypes NBAScoringChampion = new(70, "NBA Scoring Champion");
    public static readonly LeaderTypes NBASteals = new(76, "NBA Steals");
    public static readonly LeaderTypes NBLScoring = new(72, "NBL Scoring");
    public static readonly LeaderTypes NBLScoringChampion = new(69, "NBL Scoring Champion");
    public static readonly LeaderTypes NCAADivisionIScoringLeader = new (68, "NCAA Division I Scoring Leader");
    public static readonly LeaderTypes PasserRating = new (46, "NFL Passer Rating");
    public static readonly LeaderTypes PassingTouchdowns = new (45, "NFL Passing Touchdowns");
    public static readonly LeaderTypes PassingYards = new (44, "NFL Passing Yards");
    public static readonly LeaderTypes PuntingAverage = new (48, "NFL Punting Average");
    public static readonly LeaderTypes PuntingYards = new (49, "NFL Punting Yards");
    public static readonly LeaderTypes PuntReturnYards = new (79, "NFL Punt Return Yards");
    public static readonly LeaderTypes ReceivingTouchdowns = new (52, "NFL Receiving Touchdowns");
    public static readonly LeaderTypes ReceivingYards = new (50, "NFL Receiving Yards");
    public static readonly LeaderTypes Receptions = new (51, "NFL Receptions");
    public static readonly LeaderTypes Rushes = new (66, "NFL Rushes");
    public static readonly LeaderTypes RushingTouchdowns = new (37, "NFL Rushing Touchdowns");
    public static readonly LeaderTypes RushingYards = new (38, "NFL Rushing Yards");
    public static readonly LeaderTypes Sacks = new (59, "NFL Sacks");
    public static readonly LeaderTypes Scoring = new (39, "NFL Scoring");
    public static readonly LeaderTypes Tackles = new (63, "NFL Tackles");

    public static LeaderTypes[] All
        => Baseball.Union(Basketball)
                   .Union(Football)
                   .Distinct()
                   .ToArray();

    public static readonly LeaderTypes[] Baseball =
    [
        AmericanLeagueBattingChampion,
        AmericanLeagueEarnedRunAverageLeader,
        AmericanLeagueHitsLeader,
        AmericanLeagueHomeRunLeader,
        AmericanLeagueRunBattedInLeader,
        AmericanLeagueRunsLeader,
        AmericanLeagueSavesLeader,
        AmericanLeagueStolenBaseLeader,
        AmericanLeagueStrikeoutLeader,
        AmericanLeagueTriplesLeader,
        AmericanLeagueWinsLeader,
        MajorLeagueBaseballBattingChampion,
        MajorLeagueBaseballEarnedRunAverageLeader,
        MajorLeagueBaseballHitsLeader,
        MajorLeagueBaseballHomeRunLeader,
        MajorLeagueBaseballRunsBattedInLeader,
        MajorLeagueBaseballRunsLeader,
        MajorLeagueBaseballSavesLeader,
        MajorLeagueBaseballStolenBaseLeader,
        MajorLeagueBaseballStrikeoutLeader,
        MajorLeagueBaseballTriplesLeader,
        MajorLeagueBaseballWinsLeader,
        NationalLeagueAssists,
        NationalLeagueBattingChampion,
        NationalLeagueEarnedRunAverageLeader,
        NationalLeagueHitsLeader,
        NationalLeagueHomeRunLeader,
        NationalLeagueRunBattedInLeader,
        NationalLeagueRunsLeader,
        NationalLeagueSavesLeader,
        NationalLeagueStolenBaseLeader,
        NationalLeagueStrikeoutLeader,
        NationalLeagueTriplesLeader,
        NationalLeagueWinsLeader
    ];

    public static readonly LeaderTypes[] Basketball =
    [
        ABAScoringChampion,
        ABLScoring,
        BAAScoringChampion,
        NBAAssists,
        NBABlocks,
        NBAReboundingLeader,
        NBAScoringChampion,
        NBASteals,
        NBLScoring,
        NBLScoringChampion,
        NCAADivisionIScoringLeader
    ];

    public static readonly LeaderTypes[] Football =
    [
        AAFCReceivingYards,
        AAFCReceptions,
        AAFCRushingTouchdowns,
        AAFCRushingYards,
        AFLCompletionPercentage,
        AFLInterceptions,
        AFLPasserRating,
        AFLPassingTouchdowns,
        AFLPassingYards,
        AFLReceivingTouchdowns,
        AFLReceivingYards,
        AFLReceptions,
        CompletionPercentage,
        ForcedFumbles,
        Interceptions,
        KickoffReturnYards,
        PasserRating,
        PassingTouchdowns,
        PassingYards,
        PuntingAverage,
        PuntingYards,
        PuntReturnYards,
        ReceivingTouchdowns,
        ReceivingYards,
        Receptions,
        Rushes,
        RushingTouchdowns,
        RushingYards,
        Sacks,
        Scoring,
        Tackles
    ];

    private LeaderTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { } 

    public static LeaderTypes Find(int id)
        => All.SingleOrDefault(leaderType => leaderType.Id == id);

    public static LeaderTypes[] GetAll(params Sports[] sports)
    {
        if (sports.IsNullOrEmpty())
            return All;

        var leaderTypes = new List<LeaderTypes>();

        if (sports.Any(sport => sport == Sports.Baseball))
            leaderTypes.AddRange(Baseball);

        if (sports.Any(sport => sport == Sports.Basketball))
            leaderTypes.AddRange(Basketball);

        if (sports.Any(sport => sport == Sports.Football))
            leaderTypes.AddRange(Football);

        return leaderTypes.OrderBy(leaderType => leaderType.Name).ToArray();
    }

    public override string ToString()
        => Name;
}

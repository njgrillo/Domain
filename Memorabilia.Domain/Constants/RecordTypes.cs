namespace Memorabilia.Domain.Constants;

public sealed class RecordTypes : DomainItemConstants
{
    public static readonly RecordTypes AllPurposeTouchdownsInAGame = new(123, "All-Purpose Touchdowns in a Game");
    public static readonly RecordTypes AllPurposeYards = new(121, "All-Purpose Yards");
    public static readonly RecordTypes AtBats = new(31, "At Bats");
    public static readonly RecordTypes CombinedTackles = new (105, "Combined Tackles");
    public static readonly RecordTypes CompleteGames = new (45, "Complete Games");
    public static readonly RecordTypes ConsecutiveGamesPlayed = new(23, "Consecutive Games Played");
    public static readonly RecordTypes ConsecutiveHitlessInningsPitched = new (46, "Consecutive Hitless Innings Pitched");
    public static readonly RecordTypes ConsecutiveSavesToBeginCareer = new(27, "Consecutive Saves to Begin Career");
    public static readonly RecordTypes ConsecutiveSnapsPlayed = new(149, "Consecutive Snaps Played");
    public static readonly RecordTypes ConsecutiveStrikeoutsByReliefPitcher = new (84, "Consecutive Strikeouts by a Relief Pitcher");
    public static readonly RecordTypes DoublePlaysTurned = new(33, "Double Plays Turned");
    public static readonly RecordTypes Doubles = new(34, "Doubles");
    public static readonly RecordTypes EarnedRunAverage = new(16, "Earned Run Average", "ERA");
    public static readonly RecordTypes ExtraBaseHits = new(1, "Extra Base Hits");
    public static readonly RecordTypes ExtraPointsAttempted = new(72, "Extra Points Attempted");
    public static readonly RecordTypes ExtraPointsMade = new(71, "Extra Points Made");
    public static readonly RecordTypes FastestPitch = new(11, "Fastest Pitch");
    public static readonly RecordTypes FastestTo400Strikeouts = new (51, "Fastest to 400 Strikeouts");
    public static readonly RecordTypes FumbleReturnTouchdowns = new (132, "Fumble Return Touchdowns");
    public static readonly RecordTypes Games = new(30, "Games");
    public static readonly RecordTypes GamesManaged = new(20, "Games Managed");
    public static readonly RecordTypes GamesPitched = new (53, "Games Pitched");
    public static readonly RecordTypes GamesStarted = new (44, "Games Started");
    public static readonly RecordTypes GrandSlamsByPitcher = new(10, "Grand Slams By Pitcher");
    public static readonly RecordTypes HighestAveragePuntingYards = new (69, "Highest Average Punting Yards");
    public static readonly RecordTypes Hits = new (28, "Hits");
    public static readonly RecordTypes HomeRuns = new (4, "Home Runs");
    public static readonly RecordTypes HomeRunsHitByPitcher = new (54, "Home Runs Hit by Pitcher");
    public static readonly RecordTypes InningsPitched = new (43, "Innings Pitched");
    public static readonly RecordTypes InterceptionReturnYards = new (115, "Interception Return Yards");
    public static readonly RecordTypes Interceptions = new (104, "Interceptions");
    public static readonly RecordTypes InterceptionsReturnedForTouchdown = new (143, "Interceptions Returned for Touchdown");
    public static readonly RecordTypes LongestInterceptionReturn = new (116, "Longest Interception Return");
    public static readonly RecordTypes LongestReceivingTouchdown = new (108, "Longest Receiving Touchdown");
    public static readonly RecordTypes LongestRushingTouchdown = new (90, "Longest Rushing Touchdown");
    public static readonly RecordTypes LongestTenuredCoachForAFranchise = new (83, "Longest-tenured Coach for one Franchise");
    public static readonly RecordTypes LongestTouchdownPass = new (79, "Longest Touchdown Pass");
    public static readonly RecordTypes ManagerialLosses = new (19, "Managerial Losses");
    public static readonly RecordTypes ManagerialWins = new (18, "Managerial Wins");
    public static readonly RecordTypes MostCareerInterceptionsThrown = new (93, "Most Career Interceptions Thrown");
    public static readonly RecordTypes MostCareerReceivingYardsTightEnd = new (94, "Most Career Receiving Yards by a Tight End");
    public static readonly RecordTypes MostCareerReceptionsTightEnd = new (95, "Most Career Receptions by a Tight End");
    public static readonly RecordTypes MostCareerStartsWithOneTeam = new (107, "Most Career Starts with one Team");
    public static readonly RecordTypes MostConsecutive100YardReceivingGames = new (103, "Most Consecutive 100-yard Receiving Games");
    public static readonly RecordTypes MostConsecutive1000YardReceivingSeasonsToBeginCareer = new (144, "Most Consecutive 1,000 Yard Receiving Seasons to Start Career");
    public static readonly RecordTypes MostConsecutiveGamesScoring = new (65, "Most Consecutive Games Scoring");
    public static readonly RecordTypes MostConsecutiveGamesWithTouchdown = new (109, "Most Consecutive Games with a Touchdown");
    public static readonly RecordTypes MostConsecutiveHitlessAppearances = new (50, "Most Consecutive Hitless Appearances");
    public static readonly RecordTypes MostConsecutiveOutsViaStrikeout = new (49, "Most Consecutive Outs via Strikeout");
    public static readonly RecordTypes MostConsecutiveSeasonsWith250Strikeouts = new (40, "Most Consecutive Seasons with 250 Strikeouts");
    public static readonly RecordTypes MostConsecutiveSeasonsWithInterception = new (96, "Most Consecutive Seasons with an Interception");
    public static readonly RecordTypes MostConsecutiveSeasonsWithInterceptionReturnTouchdown = new (142, "Most Consecutive Seasons with an Interception Return Touchdown");
    public static readonly RecordTypes MostConsecutiveStartsByOffensiveLineman = new (134, "Most Consecutive Starts by an Offensive Lineman");
    public static readonly RecordTypes MostConsecutiveStartsByOffensiveLinemanIncludingPlayoffs = new (135, "Most Consecutive Starts by an Offensive Lineman (Including Playoffs)");
    public static readonly RecordTypes MostConsecutiveStartsByQuarterback = new (91, "Most Consecutive Starts by a Quarterback");
    public static readonly RecordTypes MostConsecutiveStartsByQuarterbackIncludingPlayoffs = new (92, "Most Consecutive Starts by a Quarterback (Including Playoffs)");
    public static readonly RecordTypes MostConsecutiveStartsByRunningBack = new(114, "Most Consecutive Starts by a Running Back");
    public static readonly RecordTypes MostConsecutiveStartsByWideReceiver = new (85, "Most Consecutive Starts by a Wide Receiver");
    public static readonly RecordTypes MostConsecutiveStartsToBeginCareer = new (140, "Most Consecutive Starts to Begin Career");
    public static readonly RecordTypes MostConsecutiveStartsToBeginCareerIncludingPlayoffs = new (141, "Most Consecutive Starts to Begin Career (Including Playoffs)");
    public static readonly RecordTypes MostConsecutiveStrikeoutsInAGame = new (21, "Most Consecutive Strikeouts in a Game");
    public static readonly RecordTypes MostConsecutiveStrikeoutsWithoutIssuingAWalkToStartSeason = new (55, "Most Consecutive Strikeouts Without Issuing a Walk to Start a Season");
    public static readonly RecordTypes MostCycles = new (42, "Most Cycles");
    public static readonly RecordTypes MostFiftyPlusYearFieldGoalsInAGame = new (66, "Most 50+ Yard Field Goals in a Game");
    public static readonly RecordTypes MostGamesPlayed = new (64, "Most Games Played");
    public static readonly RecordTypes MostHitsInADoubleHeader = new(59, "Most Hits in a Double Header");
    public static readonly RecordTypes MostHitsInAFourGameSeries = new (48, "Most Hits in a 4 Game Series");
    public static readonly RecordTypes MostImmaculateInnings = new (38, "Most Immaculate Innings");
    public static readonly RecordTypes MostInterceptionsReturnedForTouchdownInASeason = new (99, "Most Interceptions Returned for Touchdown in a Season");    
    public static readonly RecordTypes MostInterceptionsReturnedForTouchdownInASeasonByARookie = new (68, "Most Interceptions Returned for Touchdown in a Season by a Rookie");    
    public static readonly RecordTypes MostPassesInterceptedInASingleGame = new (86, "Most Passes Intercepted in a Single Game");
    public static readonly RecordTypes MostPointsScoredInAGame = new(112, "Most Points Scored in a Game");
    public static readonly RecordTypes MostReboundsInAGame = new(146, "Most Rebounds in a Game");
    public static readonly RecordTypes MostReceivingYards = new(102, "Most Receiving Yards");
    public static readonly RecordTypes MostReceivingYardsInAGameByATightEnd = new(124, "Most Receiving Yards in a Game by a Tight End");
    public static readonly RecordTypes MostRunsBattedInAGame = new(62, "Most RBI in a Game");
    public static readonly RecordTypes MostRunsBattedInOneInning = new (41, "Most RBI in One Inning");
    public static readonly RecordTypes MostRushingYardsInAGame = new (145, "Most Rushing Yards in a Game");
    public static readonly RecordTypes MostSeasonsLeadingLeagueInInterceptions = new(118, "Most Seasons Leading League in Interceptions");
    public static readonly RecordTypes MostSeasonsLeadingLeagueInPointsScored = new(100, "Most Seasons Leading League in Points Scored");
    public static readonly RecordTypes MostSeasonsLeadingLeagueInSacks = new(97, "Most Seasons Leading League in Sacks");
    public static readonly RecordTypes MostSeasonsLeadingLeagueInTouchdowns = new(101, "Most Seasons Leading League in Touchdowns");
    public static readonly RecordTypes MostSeasonsWithOneOrMoreSacks = new (128, "Most Seasons with 1+ Sacks");
    public static readonly RecordTypes MostSeasonsWithTenOrMoreSacks = new (129, "Most Seasons with 10+ Sacks");
    public static readonly RecordTypes MostStrikeoutsInANineInningGame = new (39, "Most Strikeouts in a 9 Inning Game");
    public static readonly RecordTypes NationalLeagueOnBasePercentage = new(63, "National League On-Base Percentage", "NL OBP");
    public static readonly RecordTypes NationalLeagueOnBasePlusSlugging = new(60, "National League On-Base Plus Slugging", "NL OPS");
    public static readonly RecordTypes NoHitters = new (25, "No Hitters");
    public static readonly RecordTypes OldestPlayerToTriple = new (82, "Oldest Player to hit a Triple");    
    public static readonly RecordTypes OnBasePercentage = new (6, "On-Base Percentage");    
    public static readonly RecordTypes OutfieldAssists = new (35, "Outfield Assists");
    public static readonly RecordTypes PassesDefended = new (67, "Passes Defended");
    public static readonly RecordTypes PassingAttempts = new (75, "Passing Attempts");
    public static readonly RecordTypes PassingCompletions = new (76, "Passing Completions");
    public static readonly RecordTypes PassingTouchdowns = new (77, "Passing Touchdowns");
    public static readonly RecordTypes PassingYards = new (80, "Passing Yards");
    public static readonly RecordTypes PinchHitHomeRuns = new (52, "Pinch Hit Home Runs");
    public static readonly RecordTypes PinchRunningAppearances = new (81, "Pinch Running Appearances");
    public static readonly RecordTypes PlateAppearances = new (32, "Plate Appearances");
    public static readonly RecordTypes PointsScored = new (139, "Points Scored");
    public static readonly RecordTypes PostseasonInningsPitched = new (9, "Postseason Innings Pitched");
    public static readonly RecordTypes PostseasonInterceptions = new (117, "Postseason Interceptions");
    public static readonly RecordTypes PuntReturnTouchdowns = new (148, "Punt Return Touchdowns");
    public static readonly RecordTypes PutoutsAsOutfielder = new (17, "Putouts as Outfielder");
    public static readonly RecordTypes QuarterbackWins = new (74, "Quarterback Wins");
    public static readonly RecordTypes ReceivingTouchdowns = new (110, "Receiving Touchdowns");
    public static readonly RecordTypes ReceivingTouchdownsByRookie = new (111, "Receiving Touchdowns by a Rookie");
    public static readonly RecordTypes Receptions = new (119, "Receptions");
    public static readonly RecordTypes RegularSeasonWinsAsHeadCoach = new (125, "Regular Season Wins as a Head Coach");
    public static readonly RecordTypes ReturnTouchdowns = new (147, "Return Touchdowns");
    public static readonly RecordTypes Runs = new(13, "Runs");
    public static readonly RecordTypes RunsBattingIn = new(2, "Runs Batting In", "RBI");
    public static readonly RecordTypes RunsBattedInByALeadoffHitter = new(47, "RBIs by a Leadoff Hitter");
    public static readonly RecordTypes RushingAttempts = new (131, "Rushing Attempts");
    public static readonly RecordTypes RushingTouchdowns = new (130, "Rushing Touchdowns");
    public static readonly RecordTypes RushingTouchdownsInAGame = new (113, "Rushing Touchdowns in a Game");
    public static readonly RecordTypes RushingYards = new (87, "Rushing Yards");
    public static readonly RecordTypes RushingYardsAsARookie = new (88, "Rushing Yards as a Rookie");
    public static readonly RecordTypes RushingYardsInAPlayoffGame = new (89, "Rushing Yards in a Playoff Game");
    public static readonly RecordTypes Sacked = new (78, "Sacked");
    public static readonly RecordTypes Sacks = new (127, "Sacks");
    public static readonly RecordTypes SacksInAGame = new (133, "Sacks in a Game");
    public static readonly RecordTypes Safeties = new(98, "Safeties");
    public static readonly RecordTypes Saves = new (24, "Saves");
    public static readonly RecordTypes ScrimmageTouchdowns = new (137, "Scrimmage Touchdowns");
    public static readonly RecordTypes SeasonsPlayed = new (70, "Seasons Played");
    public static readonly RecordTypes Shutouts = new (14, "Shutouts");
    public static readonly RecordTypes Singles = new (29, "Singles");
    public static readonly RecordTypes SluggingPercentage = new (7, "Slugging Percentage");
    public static readonly RecordTypes StolenBases = new (12, "Stolen Bases", "Steals");        
    public static readonly RecordTypes Strikeouts = new (26, "Strikeouts");
    public static readonly RecordTypes StrikeoutToWalkRatio = new(36, "Strikeout-to-Walk ratio");
    public static readonly RecordTypes Tackles = new(106, "Tackles");    
    public static readonly RecordTypes TotalBases = new(3, "Total Bases");    
    public static readonly RecordTypes TotalTouchdowns = new (120, "Total Touchdowns");    
    public static readonly RecordTypes TotalWinsAsHeadCoach = new (126, "Total Wins as a Head Coach");    
    public static readonly RecordTypes TouchdownPassesInAGame = new(73, "Touchdown Passes in a Game");    
    public static readonly RecordTypes TouchdownsByARookie = new(122, "Touchdowns by a Rookie");    
    public static readonly RecordTypes Triples = new(58, "Triples");    
    public static readonly RecordTypes TwoThousandStrikeoutsInFewestInningsPitched = new (37, "2000 Strikeouts in Fewest Innings Pitched");
    public static readonly RecordTypes Walks = new(5, "Walks");
    public static readonly RecordTypes WHIP = new(15, "Walks plus hits per inning pitched", "WHIP");
    public static readonly RecordTypes Wins = new(22, "Wins");
    public static readonly RecordTypes WorldSeriesEarnedRunAverage = new(8, "World Series Earned Run Average", "WS ERA");

    public static RecordTypes[] All
        => Baseball.Union(Basketball)
                   .Union(Football)
                   .Distinct()
                   .ToArray();

    public static readonly RecordTypes[] Baseball =
    [
        AtBats,
        CompleteGames,
        ConsecutiveGamesPlayed,
        ConsecutiveHitlessInningsPitched,
        ConsecutiveSavesToBeginCareer,
        ConsecutiveStrikeoutsByReliefPitcher,
        DoublePlaysTurned,
        Doubles,
        EarnedRunAverage,
        ExtraBaseHits,
        FastestPitch,
        FastestTo400Strikeouts,
        Games,
        GamesManaged,
        GamesPitched,
        GamesStarted,
        GrandSlamsByPitcher,
        Hits,
        HomeRuns,
        HomeRunsHitByPitcher,
        InningsPitched,
        LongestTenuredCoachForAFranchise,
        ManagerialLosses,
        ManagerialWins,
        MostConsecutiveHitlessAppearances,
        MostConsecutiveOutsViaStrikeout,
        MostConsecutiveSeasonsWith250Strikeouts,
        MostConsecutiveStrikeoutsInAGame,
        MostConsecutiveStrikeoutsWithoutIssuingAWalkToStartSeason,
        MostCycles,
        MostHitsInADoubleHeader,
        MostHitsInAFourGameSeries,
        MostImmaculateInnings,
        MostRunsBattedInAGame,
        MostRunsBattedInOneInning,
        MostStrikeoutsInANineInningGame,
        NationalLeagueOnBasePercentage,
        NationalLeagueOnBasePlusSlugging,
        NoHitters,
        OldestPlayerToTriple,
        OnBasePercentage,
        OutfieldAssists,
        PinchHitHomeRuns,
        PinchRunningAppearances,
        PlateAppearances,
        PostseasonInningsPitched,
        PutoutsAsOutfielder,
        Runs,
        RunsBattingIn,
        RunsBattedInByALeadoffHitter,
        Saves,
        Shutouts,
        Singles,
        SluggingPercentage,
        StolenBases,
        Strikeouts,
        StrikeoutToWalkRatio,
        TotalBases,
        Triples,
        TwoThousandStrikeoutsInFewestInningsPitched,
        Walks,
        Wins,
        WHIP,
        WorldSeriesEarnedRunAverage
    ];

    public static readonly RecordTypes[] Basketball =
    [
        MostPointsScoredInAGame,
        MostReboundsInAGame
    ];

    public static readonly RecordTypes[] Football =
    [
        AllPurposeTouchdownsInAGame,
        AllPurposeYards,
        CombinedTackles,
        ConsecutiveSnapsPlayed,
        ExtraPointsAttempted,
        ExtraPointsMade,
        FumbleReturnTouchdowns,
        HighestAveragePuntingYards,
        InterceptionReturnYards,
        Interceptions,
        InterceptionsReturnedForTouchdown,
        LongestInterceptionReturn,
        LongestReceivingTouchdown,
        LongestRushingTouchdown,
        LongestTouchdownPass,
        MostCareerInterceptionsThrown,
        MostCareerReceivingYardsTightEnd,
        MostCareerReceptionsTightEnd,
        MostCareerStartsWithOneTeam,
        MostConsecutive100YardReceivingGames,
        MostConsecutive1000YardReceivingSeasonsToBeginCareer,
        MostConsecutiveGamesScoring,
        MostConsecutiveGamesWithTouchdown,
        MostConsecutiveSeasonsWithInterception,
        MostConsecutiveSeasonsWithInterceptionReturnTouchdown,
        MostConsecutiveStartsByOffensiveLineman,
        MostConsecutiveStartsByOffensiveLinemanIncludingPlayoffs,
        MostConsecutiveStartsByQuarterback,
        MostConsecutiveStartsByQuarterbackIncludingPlayoffs,
        MostConsecutiveStartsByRunningBack,
        MostConsecutiveStartsByWideReceiver,
        MostConsecutiveStartsToBeginCareer,
        MostConsecutiveStartsToBeginCareerIncludingPlayoffs,
        MostFiftyPlusYearFieldGoalsInAGame,
        MostGamesPlayed,
        MostInterceptionsReturnedForTouchdownInASeason,
        MostInterceptionsReturnedForTouchdownInASeasonByARookie,
        MostPassesInterceptedInASingleGame,
        MostPointsScoredInAGame,
        MostReceivingYards,
        MostReceivingYardsInAGameByATightEnd,
        MostRushingYardsInAGame,
        MostSeasonsLeadingLeagueInInterceptions,
        MostSeasonsLeadingLeagueInPointsScored,
        MostSeasonsLeadingLeagueInSacks,
        MostSeasonsLeadingLeagueInTouchdowns,
        MostSeasonsWithOneOrMoreSacks,
        MostSeasonsWithTenOrMoreSacks,
        PassesDefended,
        PassingAttempts,
        PassingCompletions,
        PassingTouchdowns,
        PassingYards,
        PointsScored,
        PostseasonInterceptions,
        PuntReturnTouchdowns,
        QuarterbackWins,
        ReceivingTouchdowns,
        ReceivingTouchdownsByRookie,
        Receptions,
        RegularSeasonWinsAsHeadCoach,
        ReturnTouchdowns,
        RushingAttempts,
        RushingTouchdowns,
        RushingTouchdownsInAGame,
        RushingYards,
        RushingYardsAsARookie,
        RushingYardsInAPlayoffGame,
        Sacked,
        Sacks,
        SacksInAGame,
        Safeties,
        ScrimmageTouchdowns,
        SeasonsPlayed,
        Tackles,
        TotalTouchdowns,
        TotalWinsAsHeadCoach,
        TouchdownPassesInAGame,
        TouchdownsByARookie
    ];

    private RecordTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static RecordTypes Find(int id)
    {
        return All.SingleOrDefault(RecordTypes => RecordTypes.Id == id);
    }

    public static RecordTypes[] GetAll(params Sports[] sports)
    {
        if (sports.IsNullOrEmpty())
            return All;

        var RecordTypess = new List<RecordTypes>();

        if (sports.Any(sport => sport == Sports.Baseball))
            RecordTypess.AddRange(Baseball);

        if (sports.Any(sport => sport == Sports.Basketball))
            RecordTypess.AddRange(Basketball);

        if (sports.Any(sport => sport == Sports.Football))
            RecordTypess.AddRange(Football);

        return RecordTypess.OrderBy(RecordTypes => RecordTypes.Name).ToArray();
    }
}

namespace Memorabilia.Domain.Constants;

public sealed class TeamRoleTypes : DomainItemConstants
{
    public static readonly TeamRoleTypes Administrator = new(24, "Administrator");
    public static readonly TeamRoleTypes Assistant = new(21, "Assistant");
    public static readonly TeamRoleTypes AssistantHeadCoach = new(22, "Assistant Head Coach");
    public static readonly TeamRoleTypes BackfieldCoach = new (23, "Backfield Coach");
    public static readonly TeamRoleTypes Broadcaster = new (40, "Broadcaster");
    public static readonly TeamRoleTypes Coach = new(1, "Coach");    
    public static readonly TeamRoleTypes Consultant = new(26, "Consultant");
    public static readonly TeamRoleTypes CoOwner = new(32, "Co-Owner");
    public static readonly TeamRoleTypes DefensiveBacksCoach = new(20, "Defensive Backs Coach");
    public static readonly TeamRoleTypes DefensiveCoordinator = new(2, "Defensive Coordinator", "DC");
    public static readonly TeamRoleTypes DefensiveLineCoach = new(3, "Defensive Line Coach", "D-Line Coach");
    public static readonly TeamRoleTypes DirectorOfPlanningAndResearch = new (38, "Director of Planning and Research");
    public static readonly TeamRoleTypes DirectorOfPlayerAndCommunityRelations = new (36, "Director of Player and Community Relations");
    public static readonly TeamRoleTypes DirectorOfPlayerPersonnel = new(28, "Director of Player Personnel");
    public static readonly TeamRoleTypes DirectorOfStaffDevelopment = new (35, "Director of Staff Development");
    public static readonly TeamRoleTypes Executive = new(4, "Executive", "Exec");
    public static readonly TeamRoleTypes ExecutiveOfFootballOperationsForPlayerDevelopment = new(37, "Executive of Football Operations for Player Development");
    public static readonly TeamRoleTypes GeneralManager = new(5, "General Manager", "GM");
    public static readonly TeamRoleTypes HeadCoach = new(6, "Head Coach");
    public static readonly TeamRoleTypes HeadOfPlayerPersonnel = new (27, "Head of Player Personnel");
    public static readonly TeamRoleTypes LinebackerCoach = new(7, "Linebacker Coach");
    public static readonly TeamRoleTypes Manager = new(8, "Manager", "M");
    public static readonly TeamRoleTypes MinorityOwner = new (31, "Minority Owner");
    public static readonly TeamRoleTypes OffensiveCoordinator = new(9, "Offensive Coordinator", "OC");
    public static readonly TeamRoleTypes OffensiveEndsCoach = new(25, "Offensive Ends Coach");
    public static readonly TeamRoleTypes OffensiveLineCoach = new(10, "Offensive Line Coach", "O-Line Coach");
    public static readonly TeamRoleTypes Owner = new(11, "Owner");
    public static readonly TeamRoleTypes Player = new(12, "Player");
    public static readonly TeamRoleTypes President = new(34, "President");
    public static readonly TeamRoleTypes QuarterbackCoach = new(13, "Quarterback Coach");
    public static readonly TeamRoleTypes RunningBackCoach = new(14, "Running Back Coach");
    public static readonly TeamRoleTypes Scout = new(29, "Scout");
    public static readonly TeamRoleTypes SecondaryCoach = new(15, "Secondary Coach");    
    public static readonly TeamRoleTypes SpecialAdvisor = new (39, "Special Advisor");
    public static readonly TeamRoleTypes SpecialTeamsCoach = new(16, "Special Teams Coach");
    public static readonly TeamRoleTypes TightEndCoach = new(17, "Tight End Coach");
    public static readonly TeamRoleTypes VicePresident = new(33, "Vice President");
    public static readonly TeamRoleTypes WideReceiverCoach = new(30, "Wide Receiver Coach");

    public static TeamRoleTypes[] All
        => BaseballRoleTypes.Union(FootballRoleTypes)
                            .Distinct()
                            .ToArray();

    public static readonly TeamRoleTypes[] AdministratorRoleTypes =
    [
        Administrator,
        Assistant,
        Consultant,
        Scout,
    ];

    public static readonly TeamRoleTypes[] BaseballRoleTypes =
    [
        Broadcaster,
        Coach,
        Executive,
        GeneralManager,
        Manager,
        Owner,
        Player,
        President,
        VicePresident
    ];

    public static readonly TeamRoleTypes[] CoachRoleTypes =
    [
        Assistant,
        AssistantHeadCoach,
        BackfieldCoach,
        Coach,
        DefensiveBacksCoach,
        DefensiveCoordinator,
        DefensiveLineCoach,
        HeadCoach,
        LinebackerCoach,
        OffensiveCoordinator,
        OffensiveEndsCoach,
        OffensiveLineCoach,
        QuarterbackCoach,
        RunningBackCoach,
        SecondaryCoach,
        SpecialTeamsCoach,
        TightEndCoach,
        WideReceiverCoach
    ];

    public static readonly TeamRoleTypes[] ExecutiveRoleTypes =
    [
        Assistant,
        Consultant,
        CoOwner,
        DirectorOfPlanningAndResearch,
        DirectorOfPlayerAndCommunityRelations,
        DirectorOfPlayerPersonnel,
        DirectorOfStaffDevelopment,
        Executive,
        ExecutiveOfFootballOperationsForPlayerDevelopment,
        GeneralManager,
        HeadOfPlayerPersonnel,
        MinorityOwner,
        Owner,
        President,
        SpecialAdvisor,
        VicePresident
    ];

    public static readonly TeamRoleTypes[] FootballRoleTypes =
    [
        Administrator,
        Assistant,
        AssistantHeadCoach,
        BackfieldCoach,
        Consultant,
        CoOwner,
        DefensiveBacksCoach,
        DefensiveCoordinator,
        DefensiveLineCoach,
        DirectorOfPlanningAndResearch,
        DirectorOfPlayerAndCommunityRelations,
        DirectorOfPlayerPersonnel,
        DirectorOfStaffDevelopment,
        Executive,
        ExecutiveOfFootballOperationsForPlayerDevelopment,
        HeadCoach,
        HeadOfPlayerPersonnel,
        LinebackerCoach,
        MinorityOwner,
        OffensiveCoordinator,
        OffensiveEndsCoach,
        OffensiveLineCoach,
        Owner,
        Player,
        President,
        QuarterbackCoach,
        RunningBackCoach,
        Scout,
        SecondaryCoach,    
        SpecialAdvisor,
        SpecialTeamsCoach,
        TightEndCoach,
        VicePresident,
        WideReceiverCoach
    ];

    private TeamRoleTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static TeamRoleTypes Find(int id)
        => All.SingleOrDefault(teamRoleType => teamRoleType.Id == id);

    public static TeamRoleTypes[] Get(SportLeagueLevels sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevels.MajorLeagueBaseball)
            return BaseballRoleTypes;

        if (sportLeagueLevel == SportLeagueLevels.NationalFootballLeague)
            return FootballRoleTypes;

        return All;
    }

    public static TeamRoleTypes[] ValidTypes(Occupations occupation)
    {
        return occupation.Name switch
        {
            "Administrator" => AdministratorRoleTypes,
            "Athlete" => [Player],
            "Broadcaster" => [Broadcaster],
            "Coach" => CoachRoleTypes,
            "Executive" => ExecutiveRoleTypes,
            "GeneralManager" => [GeneralManager],
            "Manager" => [Manager],
            "Owner" => [Owner],
            _ => throw new NotImplementedException(),
        };
    }
}

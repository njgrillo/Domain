﻿namespace Memorabilia.Domain.Constants;

public sealed class TeamRoleType : DomainItemConstant
{
    public static readonly TeamRoleType Administrator = new(24, "Administrator");
    public static readonly TeamRoleType Assistant = new(21, "Assistant");
    public static readonly TeamRoleType AssistantHeadCoach = new(22, "Assistant Head Coach");
    public static readonly TeamRoleType BackfieldCoach = new (23, "Backfield Coach");
    public static readonly TeamRoleType Broadcaster = new (40, "Broadcaster");
    public static readonly TeamRoleType Coach = new(1, "Coach");    
    public static readonly TeamRoleType Consultant = new(26, "Consultant");
    public static readonly TeamRoleType CoOwner = new(32, "Co-Owner");
    public static readonly TeamRoleType DefensiveBacksCoach = new(20, "Defensive Backs Coach");
    public static readonly TeamRoleType DefensiveCoordinator = new(2, "Defensive Coordinator", "DC");
    public static readonly TeamRoleType DefensiveLineCoach = new(3, "Defensive Line Coach", "D-Line Coach");
    public static readonly TeamRoleType DirectorOfPlanningAndResearch = new (38, "Director of Planning and Research");
    public static readonly TeamRoleType DirectorOfPlayerAndCommunityRelations = new (36, "Director of Player and Community Relations");
    public static readonly TeamRoleType DirectorOfPlayerPersonnel = new(28, "Director of Player Personnel");
    public static readonly TeamRoleType DirectorOfStaffDevelopment = new (35, "Director of Staff Development");
    public static readonly TeamRoleType Executive = new(4, "Executive", "Exec");
    public static readonly TeamRoleType ExecutiveOfFootballOperationsForPlayerDevelopment = new(37, "Executive of Football Operations for Player Development");
    public static readonly TeamRoleType GeneralManager = new(5, "General Manager", "GM");
    public static readonly TeamRoleType HeadCoach = new(6, "Head Coach");
    public static readonly TeamRoleType HeadOfPlayerPersonnel = new (27, "Head of Player Personnel");
    public static readonly TeamRoleType LinebackerCoach = new(7, "Linebacker Coach");
    public static readonly TeamRoleType Manager = new(8, "Manager", "M");
    public static readonly TeamRoleType MinorityOwner = new (31, "Minority Owner");
    public static readonly TeamRoleType OffensiveCoordinator = new(9, "Offensive Coordinator", "OC");
    public static readonly TeamRoleType OffensiveEndsCoach = new(25, "Offensive Ends Coach");
    public static readonly TeamRoleType OffensiveLineCoach = new(10, "Offensive Line Coach", "O-Line Coach");
    public static readonly TeamRoleType Owner = new(11, "Owner");
    public static readonly TeamRoleType Player = new(12, "Player");
    public static readonly TeamRoleType President = new(34, "President");
    public static readonly TeamRoleType QuarterbackCoach = new(13, "Quarterback Coach");
    public static readonly TeamRoleType RunningBackCoach = new(14, "Running Back Coach");
    public static readonly TeamRoleType Scout = new(29, "Scout");
    public static readonly TeamRoleType SecondaryCoach = new(15, "Secondary Coach");    
    public static readonly TeamRoleType SpecialAdvisor = new (39, "Special Advisor");
    public static readonly TeamRoleType SpecialTeamsCoach = new(16, "Special Teams Coach");
    public static readonly TeamRoleType TightEndCoach = new(17, "Tight End Coach");
    public static readonly TeamRoleType VicePresident = new(33, "Vice President");
    public static readonly TeamRoleType WideReceiverCoach = new(30, "Wide Receiver Coach");

    public static TeamRoleType[] All
        => BaseballRoleTypes.Union(FootballRoleTypes)
                            .Distinct()
                            .ToArray();

    public static readonly TeamRoleType[] AdministratorRoleTypes =
    [
        Administrator,
        Assistant,
        Consultant,
        Scout,
    ];

    public static readonly TeamRoleType[] BaseballRoleTypes =
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

    public static readonly TeamRoleType[] CoachRoleTypes =
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

    public static readonly TeamRoleType[] ExecutiveRoleTypes =
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

    public static readonly TeamRoleType[] FootballRoleTypes =
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

    private TeamRoleType(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static TeamRoleType Find(int id)
        => All.SingleOrDefault(teamRoleType => teamRoleType.Id == id);

    public static TeamRoleType[] Get(SportLeagueLevel sportLeagueLevel)
    {
        if (sportLeagueLevel == SportLeagueLevel.MajorLeagueBaseball)
            return BaseballRoleTypes;

        if (sportLeagueLevel == SportLeagueLevel.NationalFootballLeague)
            return FootballRoleTypes;

        return All;
    }

    public static TeamRoleType[] ValidTypes(Occupation occupation)
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

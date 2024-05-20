namespace Memorabilia.Domain.Extensions;

public static class PersonExtensions
{
    public static Entities.Champion[] Championships(this List<Entities.PersonTeam> teams, 
                                                    Sports sport = null,
                                                    Occupations occupation = null)
    {
        Entities.PersonTeam[] teamsFiltered = teams.Filter(sport, occupation);

        return teamsFiltered.SelectMany(team => team.Team.Championships)
                            .Where(championship => teamsFiltered.Any(team => team.TeamId == championship.TeamId && team.BeginYear <= championship.Year && (!team.EndYear.HasValue || team.EndYear >= championship.Year)))
                            .DistinctBy(championship => new { championship.TeamId, championship.Year })
                            .ToArray();
    }

    public static bool HasChampionships(this List<Entities.PersonTeam> teams, 
                                        Sports sport = null,
                                        Occupations occupation = null)
        => Championships(teams, sport, occupation).HasAny();

    public static bool HasService(this Entities.SportService service)
        => service != null && 
           (service.FreeAgentSigningDate.HasValue || 
            service.DebutDate.HasValue || 
            service.LastAppearanceDate.HasValue);

    public static Entities.PersonTeam[] Filter(this List<Entities.PersonTeam> teams, 
                                               Sports sport = null,
                                               Occupations occupation = null)
    {
        TeamRoleTypes[] validTeamRoleTypes = occupation != null
            ? TeamRoleTypes.ValidTypes(occupation)
            : [];

        return teams.Where(team => (sport == null || sport.Id == team.Team.Franchise.SportLeagueLevel.SportId) && 
                                   (occupation == null || validTeamRoleTypes.Contains(TeamRoleTypes.Find(team.TeamRoleTypeId))))
                    .ToArray();
    }

    public static Entities.PersonAccomplishment[] Filter(this List<Entities.PersonAccomplishment> accomplishments, 
                                                         Sports sport = null,
                                                         Occupations occupation = null)
    {
        if (occupation != null && occupation != Occupations.Athlete)
            return [];

        AccomplishmentTypes[] validTypes = sport != null
            ? AccomplishmentTypes.GetAll(sport)
            : [];

        return accomplishments.Where(accomplishment => sport == null || 
                                     validTypes.Contains(AccomplishmentTypes.Find(accomplishment.AccomplishmentTypeId)))
                              .ToArray();
    }

    public static Entities.AllStar[] Filter(this List<Entities.AllStar> allStars, 
                                            Sports sport = null,
                                            Occupations occupation = null)
    {
        if (occupation != null && 
            occupation != Occupations.Athlete)
            return [];

        return allStars.Where(allStar => sport == null || 
                              sport.Id == allStar.SportId)
                       .ToArray();
    }

    public static Entities.Draft[] Filter(this List<Entities.Draft> drafts, 
                                          Sports sport = null)
        => drafts.Where(draft => sport == null || 
                        draft.Franchise.SportLeagueLevel.SportId == sport.Id)
                 .ToArray();

    public static Entities.PersonAward[] Filter(this List<Entities.PersonAward> awards, 
                                                Sports sport = null,
                                                Occupations occupation = null)
    {
        AwardTypes[] validTypes = [];

        if (sport != null && occupation != null)
            validTypes = AwardTypes.GetAll(sport, occupation);

        return awards.Where(award => sport == null || 
                            validTypes.Contains(AwardTypes.Find(award.AwardTypeId)))
                     .ToArray();
    }

    public static Entities.HallOfFame[] Filter(this List<Entities.HallOfFame> hallOfFames, 
                                               Sports sport = null)
        => hallOfFames.Where(hof => sport == null || 
                             sport.Id == SportLeagueLevels.Find(hof.SportLeagueLevelId).Sport.Id)
                      .ToArray();

    public static Entities.FranchiseHallOfFame[] Filter(this List<Entities.FranchiseHallOfFame> hallOfFames, 
                                                        Sports sport = null)
        => hallOfFames.Where(hof => sport == null || 
                             sport.Id == hof.Franchise.SportLeagueLevel.SportId)
                      .ToArray();

    public static Entities.Leader[] Filter(this List<Entities.Leader> leaders, 
                                           Sports sport = null,
                                           Occupations occupation = null)
    {
        if (occupation != null && 
            occupation != Occupations.Athlete)
            return [];   

        LeaderTypes[] validTypes = sport != null
            ? LeaderTypes.GetAll(sport)
            : [];

        return leaders.Where(leader => sport == null || 
                             validTypes.Contains(LeaderTypes.Find(leader.LeaderTypeId)))
                      .ToArray();
    }

    public static Entities.PersonPosition[] Filter(this List<Entities.PersonPosition> positions, 
                                                   Sports sport = null)
        => positions.Where(position => sport == null || 
                           position.Position.SportId == sport.Id)
                    .ToArray();

    public static Entities.CareerRecord[] Filter(this List<Entities.CareerRecord> careerRecords, 
                                                 Sports sport = null,
                                                 Occupations occupation = null)
    {
        //TODO: Filter by occupation

        RecordTypes[] validTypes = sport != null
            ? RecordTypes.GetAll(sport)
            : [];

        return careerRecords.Where(record => sport == null || 
                                   validTypes.Contains(RecordTypes.Find(record.RecordTypeId)))
                            .ToArray();
    }

    public static Entities.SingleSeasonRecord[] Filter(this List<Entities.SingleSeasonRecord> singleSeasonRecords, 
                                                       Sports sport = null)
    {
        RecordTypes[] validTypes 
            = sport != null
                ? RecordTypes.GetAll(sport)
                : [];

        return singleSeasonRecords.Where(record => sport == null || 
                                         validTypes.Contains(RecordTypes.Find(record.RecordTypeId)))
                                  .ToArray();
    }
}

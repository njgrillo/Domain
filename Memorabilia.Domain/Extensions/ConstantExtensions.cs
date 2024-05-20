namespace Memorabilia.Domain.Extensions;

public static class ConstantExtensions
{
    public static bool CanHaveAnniversary(this BaseballTypes baseballType)
        => baseballType == BaseballTypes.TeamAnniversary;

    public static bool CanHaveCost(this AcquisitionTypes acquisitionType)
        => AcquisitionTypes.CostAcquisitionTypes.Contains(acquisitionType);

    public static bool CanHavePurchaseType(this AcquisitionTypes acquisitionType)
        => acquisitionType == AcquisitionTypes.Purchase;

    public static bool CanHaveSize(this ItemTypes itemType)
        => ItemTypes.SizeTypes.Contains(itemType);

    public static bool CanHaveSpot(this ItemTypes itemType)
       => ItemTypes.SpotTypes.Contains(itemType);

    public static bool CanHaveTeam(this ItemTypes itemType)
        => ItemTypes.TeamTypes.Contains(itemType);

    public static bool CanHaveYear(this BaseballTypes baseballType)
        => BaseballTypes.Yearly.Contains(baseballType);

    public static bool CanHaveSendAndReceiveDates(this AcquisitionTypes acquisitionType)
        => acquisitionType == AcquisitionTypes.ThroughTheMail;

    public static bool CanImportByYear(this BaseballTypes baseballType)
        => BaseballTypes.ImportByYear.Contains(baseballType);

    public static bool CanImportByYearRange(this BaseballTypes baseballType)
        => BaseballTypes.ImportByYearRange.Contains(baseballType);    

    public static bool IsCommissionerType(this BaseballTypes baseballType)
        => BaseballTypes.Commissioner.Contains(baseballType);

    public static bool IsCyYoungAward(this AwardTypes awardType)
        => AwardTypes.CyYoungAwards.Contains(awardType);

    public static bool IsDateAccomplishment(this AccomplishmentTypes accomplishmentType)
         => AccomplishmentTypes.DateAccomplishment.Any(x => x.Id == accomplishmentType.Id);

    public static bool IsGameWorthly(this BaseballTypes baseballType)
        => BaseballTypes.GameWorthly.Contains(baseballType);

    public static bool IsGameWorthly(this GameStyleTypes gameStyleType)
        => GameStyleTypes.GameWorthly.Contains(gameStyleType);

    public static bool IsGameWorthlyBaseballBrand(this Brands brand)
        => Brands.GameWorthlyBaseballBrand.Contains(brand);

    public static bool IsLeaguePresidentType(this BaseballTypes baseballType)
        => BaseballTypes.LeaguePresident.Contains(baseballType);

    public static bool IsMostValuablePlayerAward(this AwardTypes awardType)
        => AwardTypes.MostValuablePlayerAwards.Contains(awardType);

    public static bool IsNavigatable(this AuthenticationCompanies authenticationCompany)
        => AuthenticationCompanies.Navigatable.Contains(authenticationCompany);

    public static bool IsPersonProject(this ProjectTypes projectType)
        => ProjectTypes.PersonProject.Contains(projectType);

    public static bool IsProjectHelmet(this HelmetFinishes helmetFinish)
        => HelmetFinishes.Project.Contains(helmetFinish);

    public static bool IsTeamProject(this ProjectTypes projectType)
        => ProjectTypes.TeamProject.Contains(projectType);

    public static bool IsWearable(this ItemTypes itemType)
        => ItemTypes.WearableTypes.Contains(itemType);

    public static bool IsYearAccomplishment(this AccomplishmentTypes accomplishmentType)
         => AccomplishmentTypes.YearAccomplishment.Any(x => x.Id == accomplishmentType.Id);

    public static bool IsYearly(this BaseballTypes baseballType) 
        => BaseballTypes.Yearly.Contains(baseballType);
}

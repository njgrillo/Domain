namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BaseballTests 
    : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithLevel, IWithMultipleTeams, IWithSinglePerson, IWithSize
{
    private readonly int _sportId
        = Sports.Baseball.Id;

    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
    {
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);
    }

    public Domain.Entities.Memorabilia SetItemBrand(Brands brand)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: brand.Id,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetItemGameStyle(GameStyleTypes gameStyleType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: gameStyleType.Id,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetItemLevel(LevelTypes levelType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: levelType.Id,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetItemSize(Sizes size)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: size.Id,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetPerson(int personId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: personId,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetTeams(params int[] teamIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Baseball);

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: 0,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: teamIds,
                                year: null);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemBrand(Brands.Spinneybeck);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BaseballShouldBeNullWhenBaseballTypeIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.Null(memorabilia.Baseball);
    }

    [Fact]
    public void BaseballShouldBeNullWhenBrandIsNotRawlingsAndBaseballTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: BaseballTypes.Official.Id,
                                brandId: Brands.Spinneybeck.Id,
                                commissionerId: GetRandomNumber(),
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        //assert
        Assert.Null(memorabilia.Baseball);
    }

    [Fact]
    public void BaseballShouldNotBeNullWhenBrandIsRawlingsAndBaseballTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: BaseballTypes.Official.Id,
                                brandId: Brands.Rawlings.Id,
                                commissionerId: GetRandomNumber(),
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        //assert
        Assert.NotNull(memorabilia.Baseball);
    }

    [Fact]
    public void CommissionerShouldBeNullWhenCommissionIdIsZero()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.Null(memorabilia.Commissioner);
    }

    [Fact]
    public void CommissionerShouldNotBeNullWhenCommissionerIsNotNullAndCommissionerIdIsGreaterThanZero()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

        int previousCommissionerId = GetRandomNumber();

        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: previousCommissionerId,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        int modifiedCommissionerId = GetRandomNumber();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: modifiedCommissionerId,
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        //assert
        Assert.NotNull(memorabilia.Commissioner);
        Assert.Equal(memorabilia.Commissioner.CommissionerId, modifiedCommissionerId);
    }

    [Fact]
    public void CommissionerShouldNotBeNullWhenCommissionerIsNullAndCommissionerIdIsGreaterThanZero()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: null,
                                brandId: DefaultBrandId,
                                commissionerId: GetRandomNumber(),
                                gameDate: null,
                                gameStyleTypeId: null,
                                leaguePresidentId: null,
                                levelTypeId: DefaultLevelTypeId,
                                personId: null,
                                sizeId: DefaultSizeId,
                                sportId: _sportId,
                                teamIds: null,
                                year: null);

        //assert
        Assert.NotNull(memorabilia.Commissioner);
    }

    [Fact]
    public void GameShouldBeNullWhenGameStyleTypeIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemGameStyle(GameStyleTypes.GameUsed);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemLevel(LevelTypes.Professional);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetPerson(GetRandomNumber());  

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Single(memorabilia.People);
    }

    [Fact]
    public void SizeShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemSize(Sizes.Standard);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Baseball);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetTeams([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Equal(2, memorabilia.Teams.Count);
    }
}

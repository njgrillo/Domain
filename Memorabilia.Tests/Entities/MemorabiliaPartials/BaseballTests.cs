namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BaseballTests 
    : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithLevel, IWithMultipleTeams, IWithSinglePerson, IWithSize
{
    private readonly int _sportId
        = Constant.Sport.Baseball.Id;

    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
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

    public Entity.Memorabilia SetItemBrand(Constant.Brand brand)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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

    public Entity.Memorabilia SetItemGameStyle(Constant.GameStyleType gameStyleType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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

    public Entity.Memorabilia SetItemLevel(Constant.LevelType levelType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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

    public Entity.Memorabilia SetItemSize(Constant.Size size)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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

    public Entity.Memorabilia SetPerson(int personId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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

    public Entity.Memorabilia SetTeams(params int[] teamIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Baseball);

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
        Entity.Memorabilia memorabilia = SetItemBrand(Constant.Brand.Spinneybeck);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BaseballShouldBeNullWhenBaseballTypeIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.Null(memorabilia.Baseball);
    }

    [Fact]
    public void BaseballShouldBeNullWhenBrandIsNotRawlingsAndBaseballTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Entity.Memorabilia();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: Constant.BaseballType.Official.Id,
                                brandId: Constant.Brand.Spinneybeck.Id,
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
        var memorabilia = new Entity.Memorabilia();

        //act
        memorabilia.SetBaseball(anniversary: string.Empty,
                                baseballTypeId: Constant.BaseballType.Official.Id,
                                brandId: Constant.Brand.Rawlings.Id,
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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.Null(memorabilia.Commissioner);
    }

    [Fact]
    public void CommissionerShouldNotBeNullWhenCommissionerIsNotNullAndCommissionerIdIsGreaterThanZero()
    {
        //arrange
        var memorabilia = new Entity.Memorabilia();

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
        var memorabilia = new Entity.Memorabilia();

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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemGameStyle(Constant.GameStyleType.GameUsed);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemLevel(Constant.LevelType.Professional);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetPerson(GetRandomNumber());  

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Single(memorabilia.People);
    }

    [Fact]
    public void SizeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemSize(Constant.Size.Standard);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Baseball);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetTeams([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Equal(2, memorabilia.Teams.Count);
    }
}

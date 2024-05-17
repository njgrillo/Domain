namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BasketballTests 
    : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithLevel, IWithSinglePerson, IWithSize, IWithSingleTeam
{
    private readonly int _sportId
        = Constant.Sport.Basketball.Id;

    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);
    }

    public Entity.Memorabilia SetItemBrand(Constant.Brand brand)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: brand.Id,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemGameStyle(Constant.GameStyleType gameStyleType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: gameStyleType.Id,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemLevel(Constant.LevelType levelType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: levelType.Id,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemSize(Constant.Size size)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: size.Id,
                                  sportId: _sportId,
                                  teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetPerson(int personId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: personId,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeam(int teamId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Basketball);

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: 0,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: teamId);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemBrand(Constant.Brand.Spalding);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BasketballShouldBeNullWhenBasketballTypeIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.Null(memorabilia.Basketball);
    }

    [Fact]
    public void CommissionerShouldBeNullWhenCommissionIdIsZero()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.Null(memorabilia.Commissioner);
    }

    [Fact]
    public void CommissionerShouldNotBeNullWhenCommissionerIsNotNullAndCommissionerIdIsGreaterThanZero()
    {
        //arrange
        var memorabilia = new Entity.Memorabilia();

        int previousCommissionerId = GetRandomNumber();

        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: previousCommissionerId,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        int modifiedCommissionerId = GetRandomNumber();

        //act
        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: modifiedCommissionerId,
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

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
        memorabilia.SetBasketball(basketballTypeId: null,
                                  brandId: DefaultBrandId,
                                  commissionerId: GetRandomNumber(),
                                  gameDate: null,
                                  gameStyleTypeId: null,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: _sportId,
                                  teamId: null);

        //assert
        Assert.NotNull(memorabilia.Commissioner);
    }

    [Fact]
    public void GameShouldBeNullWhenGameStyleTypeIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemGameStyle(Constant.GameStyleType.GameIssued);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

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
        Entity.Memorabilia memorabilia = SetItemSize(Constant.Size.Full);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Basketball);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetTeam(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Single(memorabilia.Teams);
    }
}

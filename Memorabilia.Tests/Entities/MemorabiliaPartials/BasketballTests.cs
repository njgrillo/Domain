namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BasketballTests 
    : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithLevel, IWithSinglePerson, IWithSize, IWithSingleTeam
{
    private readonly int _sportId
        = Sports.Basketball.Id;

    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
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

    public Domain.Entities.Memorabilia SetItemBrand(Brands brand)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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

    public Domain.Entities.Memorabilia SetItemGameStyle(GameStyleTypes gameStyleType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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

    public Domain.Entities.Memorabilia SetItemLevel(LevelTypes levelType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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

    public Domain.Entities.Memorabilia SetItemSize(Sizes size)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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

    public Domain.Entities.Memorabilia SetPerson(int personId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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

    public Domain.Entities.Memorabilia SetTeam(int teamId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Basketball);

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
        Domain.Entities.Memorabilia memorabilia = SetItemBrand(Brands.Spalding);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BasketballShouldBeNullWhenBasketballTypeIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.Null(memorabilia.Basketball);
    }

    [Fact]
    public void CommissionerShouldBeNullWhenCommissionIdIsZero()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.Null(memorabilia.Commissioner);
    }

    [Fact]
    public void CommissionerShouldNotBeNullWhenCommissionerIsNotNullAndCommissionerIdIsGreaterThanZero()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

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
        var memorabilia = new Domain.Entities.Memorabilia();

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
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemGameStyle(GameStyleTypes.GameIssued);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

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
        Domain.Entities.Memorabilia memorabilia = SetItemSize(Sizes.Full);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Basketball);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetTeam(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Single(memorabilia.Teams);
    }
}

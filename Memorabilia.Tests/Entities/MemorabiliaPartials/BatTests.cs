namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BatTests : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithSinglePerson, IWithSingleTeam, IWithSize
{
    private readonly int _sportId
        = Constant.Sport.Baseball.Id;

    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBat(batTypeId: null,
                           brandId: DefaultBrandId,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: null,
                           length: null,
                           personId: null,
                           sizeId: DefaultSizeId,
                           sportId: _sportId,
                           teamId: null);
    }

    public Entity.Memorabilia SetItemBrand(Constant.Brand brand)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bat);

        memorabilia.SetBat(batTypeId: null,
                           brandId: brand.Id,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: null,
                           length: null,
                           personId: null,
                           sizeId: DefaultSizeId,
                           sportId: _sportId,
                           teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemGameStyle(Constant.GameStyleType gameStyleType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bat);

        memorabilia.SetBat(batTypeId: null,
                           brandId: DefaultBrandId,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: gameStyleType.Id,
                           length: null,
                           personId: null,
                           sizeId: DefaultSizeId,
                           sportId: _sportId,
                           teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemSize(Constant.Size size)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bat);

        memorabilia.SetBat(batTypeId: null,
                           brandId: DefaultBrandId,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: null,
                           length: null,
                           personId: null,
                           sizeId: size.Id,
                           sportId: _sportId,
                           teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetPerson(int personId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bat);

        memorabilia.SetBat(batTypeId: null,
                           brandId: DefaultBrandId,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: null,
                           length: null,
                           personId: personId,
                           sizeId: DefaultSizeId,
                           sportId: _sportId,
                           teamId: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeam(int teamId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bat);

        memorabilia.SetBat(batTypeId: null,
                           brandId: DefaultBrandId,
                           colorId: null,
                           gameDate: null,
                           gameStyleTypeId: null,
                           length: null,
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
        Entity.Memorabilia memorabilia = SetItemBrand(Constant.Brand.LouisvilleSlugger);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BatShouldBeNullWhenBatTypeIsNullAndColorIsNullAndLengthIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

        //assert
        Assert.Null(memorabilia.Bat);
    }

    [Fact]
    public void GameShouldBeNullWhenGameStyleTypeIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemGameStyle(Constant.GameStyleType.None);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bat);

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

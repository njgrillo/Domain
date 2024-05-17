namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class CanvasTests 
    : MemorabiliaItemTests, IWithBrand, IWithMultiplePeople, IWithMultipleSports, IWithMultipleTeams, IWithSize
{
    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetCanvas(brandId: DefaultBrandId,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: null,
                              sizeId: DefaultSizeId,
                              sportIds: null,
                              stretched: false,
                              teamIds: null);
    }

    public Entity.Memorabilia SetItemBrand(Constant.Brand brand)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        memorabilia.SetCanvas(brandId: brand.Id,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: null,
                              sizeId: DefaultSizeId,
                              sportIds: null,
                              stretched: false,
                              teamIds: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemSize(Constant.Size size)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        memorabilia.SetCanvas(brandId: DefaultBrandId,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: null,
                              sizeId: size.Id,
                              sportIds: null,
                              stretched: false,
                              teamIds: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetPerson(params int[] personIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        memorabilia.SetCanvas(brandId: DefaultBrandId,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: personIds,
                              sizeId: DefaultSizeId,
                              sportIds: null,
                              stretched: false,
                              teamIds: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetSports(params int[] sportIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        memorabilia.SetCanvas(brandId: DefaultBrandId,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: null,
                              sizeId: DefaultSizeId,
                              sportIds: sportIds,
                              stretched: false,
                              teamIds: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeams(params int[] teamIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        memorabilia.SetCanvas(brandId: DefaultBrandId,
                              matted: false,
                              orientationId: GetRandomNumber(),
                              personIds: null,
                              sizeId: DefaultSizeId,
                              sportIds: null,
                              stretched: false,
                              teamIds: teamIds);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemBrand(Constant.Brand.Photofile);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Canvas);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Canvas);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetPerson([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Equal(2, memorabilia.People.Count);
    }

    [Fact]
    public void SizeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemSize(Constant.Size.None);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmptyWhenNoSportsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Canvas);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.Empty(memorabilia.Sports);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmptyWhenSportsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetSports([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(2, memorabilia.Sports.Count);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Canvas);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange
        Entity.Memorabilia memorabilia = SetTeams([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Equal(2, memorabilia.Teams.Count);
    }
}

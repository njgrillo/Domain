namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class CanvasTests 
    : MemorabiliaItemTests, IWithBrand, IWithMultiplePeople, IWithMultipleSports, IWithMultipleTeams, IWithSize
{
    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
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

    public Domain.Entities.Memorabilia SetItemBrand(Brands brand)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

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

    public Domain.Entities.Memorabilia SetItemSize(Sizes size)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

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

    public Domain.Entities.Memorabilia SetPerson(params int[] personIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

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

    public Domain.Entities.Memorabilia SetSports(params int[] sportIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

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

    public Domain.Entities.Memorabilia SetTeams(params int[] teamIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

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
        Domain.Entities.Memorabilia memorabilia = SetItemBrand(Brands.Photofile);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Canvas);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Canvas);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetPerson([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Equal(2, memorabilia.People.Count);
    }

    [Fact]
    public void SizeShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemSize(Sizes.None);

        //assert
        Assert.NotNull(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmptyWhenNoSportsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Canvas);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.Empty(memorabilia.Sports);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmptyWhenSportsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetSports([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(2, memorabilia.Sports.Count);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Canvas);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange
        Domain.Entities.Memorabilia memorabilia = SetTeams([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Equal(2, memorabilia.Teams.Count);
    }
}

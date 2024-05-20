namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BatTests : MemorabiliaItemTests, IWithBrand, IWithGameStyle, IWithSinglePerson, IWithSingleTeam, IWithSize
{
    private readonly int _sportId
        = Sports.Baseball.Id;

    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
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

    public Domain.Entities.Memorabilia SetItemBrand(Brands brand)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bat);

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

    public Domain.Entities.Memorabilia SetItemGameStyle(GameStyleTypes gameStyleType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bat);

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

    public Domain.Entities.Memorabilia SetItemSize(Sizes size)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bat);

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

    public Domain.Entities.Memorabilia SetPerson(int personId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bat);

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

    public Domain.Entities.Memorabilia SetTeam(int teamId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bat);

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
        Domain.Entities.Memorabilia memorabilia = SetItemBrand(Brands.LouisvilleSlugger);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BatShouldBeNullWhenBatTypeIsNullAndColorIsNullAndLengthIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

        //assert
        Assert.Null(memorabilia.Bat);
    }

    [Fact]
    public void GameShouldBeNullWhenGameStyleTypeIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void GameShouldNotBeNullWhenGameStyleTypeIdIsNotNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemGameStyle(GameStyleTypes.None);

        //assert
        Assert.NotNull(memorabilia.Game);
    }    

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

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
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Equal(_sportId, memorabilia.Sports.First().SportId);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bat);

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

namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BammerTests : MemorabiliaItemTests, IWithBrand, IWithMultiplePeople, IWithMultipleTeams, IWithSingleSport
{
    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);
    }

    public Entity.Memorabilia SetItemBrand(Constant.Brand brand)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: brand.Id,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetPerson(params int[] personIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: personIds,
                              sportId: null,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetSport(int sportId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: null,
                              sportId: sportId,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeams(params int[] teamIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: teamIds,
                              year: null);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemBrand(Constant.Brand.Other);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BammerShouldBeNullWhenBammerTypeIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bammer);

        //assert
        Assert.Null(memorabilia.Bammer);
    }

    [Fact]
    public void BammerShouldBeNullWhenBrandIsNotSalvinoAndBammerTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Entity.Memorabilia();

        //act
        memorabilia.SetBammer(bammerTypeId: Constant.BammerType.Bammer.Id,
                              brandId: Constant.Brand.Salvino.Id,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);

        //assert
        Assert.Null(memorabilia.Baseball);
    }

    [Fact]
    public void BammerShouldNotBeNullWhenBrandIsSalvinoAndBammerTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Entity.Memorabilia();

        //act
        memorabilia.SetBammer(bammerTypeId: Constant.BammerType.Bammer.Id,
                              brandId: Constant.Brand.Salvino.Id,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);

        //assert
        Assert.NotNull(memorabilia.Bammer);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bammer);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange
        Entity.Memorabilia memorabilia = SetPerson(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Single(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldContainMoreThanOneItemWhenPersonIdsIsNotNullAndMoreThanOnePersonIdIsSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetPerson([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Equal(2, memorabilia.People.Count);
    }

    [Fact]
    public void SizeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bammer);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetSport(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Single(memorabilia.Sports);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bammer);

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

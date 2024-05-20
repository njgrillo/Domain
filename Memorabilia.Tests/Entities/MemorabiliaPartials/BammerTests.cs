namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BammerTests 
    : MemorabiliaItemTests, IWithBrand, IWithMultiplePeople, IWithMultipleTeams, IWithSingleSport
{
    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
    {
        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);
    }

    public Domain.Entities.Memorabilia SetItemBrand(Brands brand)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: brand.Id,
                              inPackage: false,
                              personIds: null,
                              sportId: null,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetPerson(params int[] personIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: personIds,
                              sportId: null,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetSport(int sportId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        memorabilia.SetBammer(bammerTypeId: null,
                              brandId: DefaultBrandId,
                              inPackage: false,
                              personIds: null,
                              sportId: sportId,
                              teamIds: null,
                              year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetTeams(params int[] teamIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

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
        Domain.Entities.Memorabilia memorabilia = SetItemBrand(Brands.Other);

        //assert
        Assert.NotNull(memorabilia.Brand);
    }

    [Fact]
    public void BammerShouldBeNullWhenBammerTypeIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bammer);

        //assert
        Assert.Null(memorabilia.Bammer);
    }

    [Fact]
    public void BammerShouldBeNullWhenBrandIsNotSalvinoAndBammerTypeIsNotNull()
    {
        //arrange
        var memorabilia = new Domain.Entities.Memorabilia();

        //act
        memorabilia.SetBammer(bammerTypeId: BammerTypes.Bammer.Id,
                              brandId: Brands.Salvino.Id,
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
        var memorabilia = new Domain.Entities.Memorabilia();

        //act
        memorabilia.SetBammer(bammerTypeId: BammerTypes.Bammer.Id,
                              brandId: Brands.Salvino.Id,
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
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bammer);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.Empty(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldNotBeEmptyWhenPersonIdIsNotNull()
    {
        //arrange
        Domain.Entities.Memorabilia memorabilia = SetPerson(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Single(memorabilia.People);
    }

    [Fact]
    public void PeopleShouldContainMoreThanOneItemWhenPersonIdsIsNotNullAndMoreThanOnePersonIdIsSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetPerson([GetRandomNumber(), GetRandomNumber()]);

        //assert
        Assert.NotNull(memorabilia.People);
        Assert.NotEmpty(memorabilia.People);
        Assert.Equal(2, memorabilia.People.Count);
    }

    [Fact]
    public void SizeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bammer);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndNotEmpty()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetSport(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.NotEmpty(memorabilia.Sports);
        Assert.Single(memorabilia.Sports);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmptyWhenNoTeamsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bammer);

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

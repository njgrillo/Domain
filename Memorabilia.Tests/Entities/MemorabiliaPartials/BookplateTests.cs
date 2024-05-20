namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BookplateTests : MemorabiliaItemTests, IWithSinglePerson
{
    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
    {
        memorabilia.SetBookplate(personId: null);
    }

    public Domain.Entities.Memorabilia SetPerson(int personId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        memorabilia.SetBookplate(personId);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bookplate);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bookplate);

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
    public void SizeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmpty()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.Empty(memorabilia.Sports);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmpty()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bookplate);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }
}

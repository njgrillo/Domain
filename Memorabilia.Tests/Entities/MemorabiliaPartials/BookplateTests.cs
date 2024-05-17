namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BookplateTests : MemorabiliaItemTests, IWithSinglePerson
{
    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBookplate(personId: null);
    }

    public Entity.Memorabilia SetPerson(int personId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        memorabilia.SetBookplate(personId);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bookplate);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bookplate);

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
    public void SizeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmpty()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        //assert
        Assert.NotNull(memorabilia.Sports);
        Assert.Empty(memorabilia.Sports);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndEmpty()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bookplate);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }
}

namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BookTests : MemorabiliaItemTests, IWithMultiplePeople, IWithMultipleSports, IWithMultipleTeams
{
    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: null,
                            publisher: string.Empty,
                            sportIds: null,
                            teamIds: null,
                            title: string.Empty);
    }

    public Entity.Memorabilia SetPerson(params int[] personIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: personIds,
                            publisher: string.Empty,
                            sportIds: null,
                            teamIds: null,
                            title: string.Empty);

        return memorabilia;
    }

    public Entity.Memorabilia SetSports(params int[] sportIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: null,
                            publisher: string.Empty,
                            sportIds: sportIds,
                            teamIds: null,
                            title: string.Empty);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeams(params int[] teamIds)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: null,
                            publisher: string.Empty,
                            sportIds: null,
                            teamIds: teamIds,
                            title: string.Empty);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Book);

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
    public void SizeShouldBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Book);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmptyWhenNoSportsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Book);

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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Book);

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

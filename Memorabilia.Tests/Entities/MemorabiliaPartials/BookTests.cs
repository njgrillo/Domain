namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BookTests : MemorabiliaItemTests, IWithMultiplePeople, IWithMultipleSports, IWithMultipleTeams
{
    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
    {
        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: null,
                            publisher: string.Empty,
                            sportIds: null,
                            teamIds: null,
                            title: string.Empty);
    }

    public Domain.Entities.Memorabilia SetPerson(params int[] personIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: personIds,
                            publisher: string.Empty,
                            sportIds: null,
                            teamIds: null,
                            title: string.Empty);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetSports(params int[] sportIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        memorabilia.SetBook(edition: string.Empty,
                            hardCover: false,
                            personIds: null,
                            publisher: string.Empty,
                            sportIds: sportIds,
                            teamIds: null,
                            title: string.Empty);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetTeams(params int[] teamIds)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

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
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void GameShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        //assert
        Assert.Null(memorabilia.Game);
    }

    [Fact]
    public void LevelTypeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        //assert
        Assert.Null(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Book);

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
    public void SizeShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Book);

        //assert
        Assert.Null(memorabilia.Size);
    }

    [Fact]
    public void SportsShouldNotBeNullAndEmptyWhenNoSportsAreSpecified()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Book);

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
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Book);

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

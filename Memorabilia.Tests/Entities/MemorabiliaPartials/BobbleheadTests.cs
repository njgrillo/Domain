namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BobbleheadTests 
    : MemorabiliaItemTests, IWithLevel, IWithSinglePerson, IWithSingleSport, IWithSingleTeam, IWithSize
{
    protected override void SetDefaultItem(Domain.Entities.Memorabilia memorabilia)
    {
        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);
    }

    public Domain.Entities.Memorabilia SetItemLevel(LevelTypes levelType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: levelType.Id,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetItemSize(Sizes size)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: size.Id,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetPerson(int personId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: personId,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetSport(int sportId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: sportId,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Domain.Entities.Memorabilia SetTeam(int teamId)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(ItemTypes.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: teamId,
                                  year: null);

        return memorabilia;
    }

    [Fact]
    public void BrandShouldBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bobble);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void BobbleheadShouldNotBeNull()
    {
        //arrange
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bobble);

        //assert
        Assert.NotNull(memorabilia.Bobblehead);
    }

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetItemLevel(LevelTypes.Professional);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bobble);

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
        Domain.Entities.Memorabilia memorabilia = SetItemSize(Sizes.Standard);

        //assert
        Assert.NotNull(memorabilia.Size);
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
        Domain.Entities.Memorabilia memorabilia = SetDefaultItem(ItemTypes.Bobble);

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

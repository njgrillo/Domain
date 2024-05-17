namespace Memorabilia.Tests.Entities.MemorabiliaPartials;

public class BobbleheadTests 
    : MemorabiliaItemTests, IWithLevel, IWithSinglePerson, IWithSingleSport, IWithSingleTeam, IWithSize
{
    protected override void SetDefaultItem(Entity.Memorabilia memorabilia)
    {
        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);
    }

    public Entity.Memorabilia SetItemLevel(Constant.LevelType levelType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: levelType.Id,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetItemSize(Constant.Size size)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: size.Id,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetPerson(int personId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: personId,
                                  sizeId: DefaultSizeId,
                                  sportId: null,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetSport(int sportId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bobble);

        memorabilia.SetBobblehead(hasBox: false,
                                  levelTypeId: DefaultLevelTypeId,
                                  personId: null,
                                  sizeId: DefaultSizeId,
                                  sportId: sportId,
                                  teamId: null,
                                  year: null);

        return memorabilia;
    }

    public Entity.Memorabilia SetTeam(int teamId)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(Constant.ItemType.Bobble);

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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bobble);

        //assert
        Assert.Null(memorabilia.Brand);
    }

    [Fact]
    public void BobbleheadShouldNotBeNull()
    {
        //arrange
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bobble);

        //assert
        Assert.NotNull(memorabilia.Bobblehead);
    }

    [Fact]
    public void LevelTypeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemLevel(Constant.LevelType.Professional);

        //assert
        Assert.NotNull(memorabilia.LevelType);
    }

    [Fact]
    public void PeopleShouldBeEmptyWhenPersonIdIsNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bobble);

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
    public void SizeShouldNotBeNull()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetItemSize(Constant.Size.Standard);

        //assert
        Assert.NotNull(memorabilia.Size);
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
        Entity.Memorabilia memorabilia = SetDefaultItem(Constant.ItemType.Bobble);

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.Empty(memorabilia.Teams);
    }

    [Fact]
    public void TeamsShouldNotBeNullAndNotEmptyWhenTeamsAreSpecified()
    {
        //arrange & act
        Entity.Memorabilia memorabilia = SetTeam(GetRandomNumber());

        //assert
        Assert.NotNull(memorabilia.Teams);
        Assert.NotEmpty(memorabilia.Teams);
        Assert.Single(memorabilia.Teams);
    }
}

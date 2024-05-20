namespace Memorabilia.Tests.Common;

public abstract class MemorabiliaItemTests : MemorabiliaTests
{
    protected static int DefaultBrandId
        => Brands.None.Id;

    protected static int DefaultGameStyleTypeId
        => GameStyleTypes.None.Id;

    protected static int DefaultLevelTypeId
        => LevelTypes.None.Id;

    protected static int DefaultSizeId
        => Sizes.None.Id;

    protected abstract void SetDefaultItem(Domain.Entities.Memorabilia memorabilia);

    protected virtual Domain.Entities.Memorabilia SetDefaultItem(ItemTypes itemType)
    {
        Domain.Entities.Memorabilia memorabilia = GetMemorabilia(itemType);

        SetDefaultItem(memorabilia);

        return memorabilia;
    }
}

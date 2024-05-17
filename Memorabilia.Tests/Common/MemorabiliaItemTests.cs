namespace Memorabilia.Tests.Common;

public abstract class MemorabiliaItemTests : MemorabiliaTests
{
    protected static int DefaultBrandId
        => Constant.Brand.None.Id;

    protected static int DefaultGameStyleTypeId
        => Constant.GameStyleType.None.Id;

    protected static int DefaultLevelTypeId
        => Constant.LevelType.None.Id;

    protected static int DefaultSizeId
        => Constant.Size.None.Id;

    protected abstract void SetDefaultItem(Entity.Memorabilia memorabilia);

    protected virtual Entity.Memorabilia SetDefaultItem(Constant.ItemType itemType)
    {
        Entity.Memorabilia memorabilia = GetMemorabilia(itemType);

        SetDefaultItem(memorabilia);

        return memorabilia;
    }
}

namespace Memorabilia.Domain.Entities;

public class ItemTypeSize : Entity
{
    public ItemTypeSize() { }

    public ItemTypeSize(int itemTypeId, int sizeId)
    {
        ItemTypeId = itemTypeId;
        SizeId = sizeId;
    }

    public int ItemTypeId { get; private set; }

    public string ItemTypeName => ItemTypes.Find(ItemTypeId)?.Name;

    public int SizeId { get; private set; }

    public string SizeName => Constants.Sizes.Find(SizeId)?.Name;

    public void Set(int sizeId)
    {
        SizeId = sizeId;
    }
}

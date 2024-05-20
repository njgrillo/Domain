namespace Memorabilia.Domain.Entities;

public class ItemTypeSpot : Entity
{
    public ItemTypeSpot() { }

    public ItemTypeSpot(int itemTypeId, int spotId)
    {
        ItemTypeId = itemTypeId;
        SpotId = spotId;
    }

    public int ItemTypeId { get; private set; }

    public string ItemTypeName => ItemTypes.Find(ItemTypeId)?.Name;

    public int SpotId { get; private set; }

    public string SpotName => ItemTypes.Find(SpotId)?.Name;

    public void Set(int spotId)
    {
        SpotId = spotId;
    }
}

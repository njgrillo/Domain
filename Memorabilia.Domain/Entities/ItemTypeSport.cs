namespace Memorabilia.Domain.Entities;

public class ItemTypeSport : Entity
{
    public ItemTypeSport() { }

    public ItemTypeSport(int itemTypeId, int sportId)
    {
        ItemTypeId = itemTypeId;
        SportId = sportId;
    }

    public int ItemTypeId { get; private set; }

    public string ItemTypeName => ItemTypes.Find(ItemTypeId)?.Name;

    public int SportId { get; private set; }

    public string SportName => Constants.Sports.Find(SportId)?.Name;

    public void Set(int sportId)
    {
        SportId = sportId;
    }
}

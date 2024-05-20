namespace Memorabilia.Domain.Entities;

public class ItemTypeLevel : Entity
{
    public ItemTypeLevel() { }

    public ItemTypeLevel(int itemTypeId, int levelTypeId)
    {
        ItemTypeId = itemTypeId;
        LevelTypeId = levelTypeId;
    }        

    public int ItemTypeId { get; private set; }

    public string ItemTypeName => ItemTypes.Find(ItemTypeId)?.Name;

    public int LevelTypeId { get; private set; }

    public string LevelTypeName => LevelTypes.Find(LevelTypeId)?.Name;

    public void Set(int levelTypeId)
    {
        LevelTypeId = levelTypeId;
    }
}

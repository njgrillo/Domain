﻿namespace Memorabilia.Domain.Entities;

public class ItemTypeGameStyleType : Entity
{
    public ItemTypeGameStyleType() { }

    public ItemTypeGameStyleType(int itemTypeId, int gameStyleTypeId)
    {
        ItemTypeId = itemTypeId;
        GameStyleTypeId = gameStyleTypeId;
    }

    public int GameStyleTypeId { get; private set; }

    public string GameStyleTypeName => Constants.GameStyleType.Find(GameStyleTypeId)?.Name;

    public int ItemTypeId { get; private set; }

    public string ItemTypeName => Constants.ItemType.Find(ItemTypeId)?.Name;

    public void Set(int gameStyleTypeId)
    {
        GameStyleTypeId = gameStyleTypeId;
    }
}



﻿namespace Memorabilia.Domain.Entities;

public class MemorabiliaFirstDayCover : Entity
{
    public MemorabiliaFirstDayCover() { }

    public MemorabiliaFirstDayCover(int memorabiliaId, DateTime? date)
    {
        MemorabiliaId = memorabiliaId;
        Date = date;
    }

    public DateTime? Date { get; private set; }

    public int MemorabiliaId { get; private set; }

    public void Set(DateTime? date)
    {
        Date = date;
    }
}

﻿namespace Memorabilia.Domain.Entities;

public class MemorabiliaSport : Entity
{
    public MemorabiliaSport() { }

    public MemorabiliaSport(int memorabiliaId, int sportId)
    {
        MemorabiliaId = memorabiliaId;
        SportId = sportId;
    }

    public int MemorabiliaId { get; private set; }

    public virtual Sport Sport { get; private set; }

    public int SportId { get; private set; }

    public void Set(int sportId)
    {
        SportId = sportId;
    }
}

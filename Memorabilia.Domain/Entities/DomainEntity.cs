﻿namespace Memorabilia.Domain.Entities;

public  class DomainEntity : Entity
{
    public DomainEntity() { }

    public DomainEntity(string name, string abbreviation)
    {
        Name = name;
        Abbreviation = abbreviation;
    }

    public string Abbreviation { get; private set; }

    public string Name { get; private set; }

    public void Set(string name, string abbreviation)
    {
        Name = name;
        Abbreviation = abbreviation; 
    }
}

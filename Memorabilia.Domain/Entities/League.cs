﻿namespace Memorabilia.Domain.Entities;

public class League : Entity
{
    public League() { }

    public League(int sportLeagueLevelId, string name, string abbreviation)
    {
        SportLeagueLevelId = sportLeagueLevelId;
        Name = name;
        Abbreviation = abbreviation;
    }

    public string Abbreviation { get; set; }

    public string Name { get; set; }

    public int SportLeagueLevelId { get; set; }

    public void Set(int sportLeagueLevelId, string name, string abbreviation)
    {
        SportLeagueLevelId = sportLeagueLevelId;
        Name = name;
        Abbreviation = abbreviation;
    }
}

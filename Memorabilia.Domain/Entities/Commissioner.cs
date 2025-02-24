﻿namespace Memorabilia.Domain.Entities;

public class Commissioner : Entity
{
    public Commissioner() { }

    public Commissioner(int sportLeagueLevelId, int personId, int? beginYear, int? endYear)
    {
        SportLeagueLevelId = sportLeagueLevelId;
        PersonId = personId;
        BeginYear = beginYear;
        EndYear = endYear;
    }

    public int? BeginYear { get; private set; }

    public int? EndYear { get; private set; }

    public virtual Person Person { get; set; }

    public int PersonId { get; private set; }

    public int SportLeagueLevelId { get; private set; }

    public string SportLeagueLevelName 
        => Constant.SportLeagueLevel.Find(SportLeagueLevelId)?.Name;

    public void Set(int? beginYear, int? endYear)
    {
        BeginYear = beginYear;
        EndYear = endYear;
    }
}

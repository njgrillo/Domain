namespace Memorabilia.Domain.SearchModels;

public class SearchCriteria
{
    public DateTime? AcquiredDateBegin { get; set; }

    public DateTime? AcquiredDateEnd { get; set; }

    public IEnumerable<int> AcquisitionTypeIds { get; set; }
        = [];

    public AutographFilters AutographFilter { get; set; }
        = AutographFilters.None;

    public string AutographFilterName
        => AutographFilter.Name;

    public IEnumerable<int> ConditionIds { get; set; }
        = [];

    public decimal? CostHigh { get; set; }

    public decimal? CostLow { get; set; }

    public decimal? EstimatedValueHigh { get; set; }

    public decimal? EstimatedValueLow { get; set; }

    public IEnumerable<int> FranchiseIds { get; set; }
        = [];

    public ImageFilters ImageFilter { get; set; } 
        = ImageFilters.None;

    public string ImageFilterName 
        => ImageFilter.Name;

    public List<Entities.Person> People { get; set; } 
        = [];

    public int[] PersonIds 
        => People.Select(person => person.Id)
                 .Distinct()
                 .ToArray();

    public IEnumerable<int> PurchaseTypeIds { get; set; }
        = [];

    public IEnumerable<int> SportIds { get; set; }
        = [];

    public IEnumerable<int> SportLeagueLevelIds { get; set; }
        = [];

    public int[] TeamIds
        => Teams.Select(team => team.Id)
                .Distinct()
                .ToArray();

    public List<Entities.Team> Teams { get; set; } 
        = [];    
}

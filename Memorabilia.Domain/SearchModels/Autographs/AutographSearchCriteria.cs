namespace Memorabilia.Domain.SearchModels.Autographs;

public class AutographSearchCriteria : SearchCriteria
{
    public AuthenticationFilters AuthenticationFilter { get; set; } 
        = AuthenticationFilters.None;

    public string AuthenticationFilterName
        => AuthenticationFilter.Name;

    public IEnumerable<int> ColorIds { get; set; }
        = [];

    public int? Grade { get; set; }

    public InscriptionFilters InscriptionFilter { get; set; } 
        = InscriptionFilters.None;

    public string InscriptionFilterName
        => InscriptionFilter.Name;

    public PersonalizationFilters PersonalizationFilter { get; set; } 
        = PersonalizationFilters.None;

    public string PersonalizationFilterName
        => PersonalizationFilter.Name;

    public IEnumerable<int> SpotIds { get; set; }
        = [];

    public IEnumerable<int> WritingInstrumentIds { get; set; }
        = [];
}

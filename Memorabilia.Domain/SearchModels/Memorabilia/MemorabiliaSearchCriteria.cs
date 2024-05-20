namespace Memorabilia.Domain.SearchModels.Memorabilia;

public class MemorabiliaSearchCriteria : SearchCriteria
{
    public AutographSearchCriteria AutographSearchCriteria { get; set; } 
        = new();

    public BuyNowFilters BuyNowFilter { get; set; }
        = BuyNowFilters.None;

    public string BuyNowFilterName
        => BuyNowFilter.Name;

    public IEnumerable<int> BrandIds { get; set; }
        = [];

    public IEnumerable<int> GameStyleTypeIds { get; set; }
        = [];

    public bool IncludeMyMemorablia { get; set; }

    public bool IncludeSold { get; set; }

    public bool IncludeTraded { get; set; }

    public IEnumerable<int> ItemTypeIds { get; set; }
        = [];

    public IEnumerable<int> LevelTypeIds { get; set; }
        = [];

    public MakeOfferFilters MakeOfferFilter { get; set; }
        = MakeOfferFilters.None;

    public string MakeOfferFilterName
        => MakeOfferFilter.Name;

    public IEnumerable<int> PrivacyTypeIds { get; set; } 
        = [];

    public SaleFilters SaleFilter { get; set; }
        = SaleFilters.None;

    public string SaleFilterName
        => SaleFilter.Name;

    public IEnumerable<int> SizeIds { get; set; } 
        = [];

    public TradeFilters TradeFilter { get; set; }
        = TradeFilters.None;

    public string TradeFilterName
        => TradeFilter.Name;
}

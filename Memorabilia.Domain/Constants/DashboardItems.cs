namespace Memorabilia.Domain.Constants;

public sealed class DashboardItems : DomainItemConstants
{        
    public static readonly DashboardItems AutographAcquisitionTypeDonutChart = new(20, "Autograph Acquisition Type Donut Chart", "Displays a donut chart of the different acquisition types of the autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems AutographAcquisitionTypePieChart = new(5, "Autograph Acquisition Type Pie Chart", "Displays a pie chart of the different acquisition types of the autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems AutographConditionDonutChart = new(21, "Autograph Condition Donut Chart", "Displays a donut chart of the different conditions of the autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems AutographConditionPieChart = new(8, "Autograph Condition Pie Chart", "Displays a pie chart of the different conditions of the autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems BrandDonutChart = new (22, "Brand Donut Chart", "Displays a donut chart of the brands of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems BrandPieChart = new(6, "Brand Pie Chart", "Displays a pie chart of the brands of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems ColorDonutChart = new(23, "Color Donut Chart", "Displays a donut chart of the colors of the autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems ColorPieChart = new(12, "Color Pie Chart", "Displays a pie chart of the colors of the autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems CostDonutChart = new(24, "Cost Donut Chart", "Displays a donut chart of the cost of the memorabilia and autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems CostPieChart = new(14, "Cost Pie Chart", "Displays a pie chart of the cost of the memorabilia and autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems EstimatedValueDonutChart = new(25, "Estimated Value Donut Chart", "Displays a donut chart of the estimated value of the memorabilia and autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems EstimatedValuePieChart = new(3, "Estimated Value Pie Chart", "Displays a pie chart of the estimated value of the memorabilia and autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems FranchiseDonutChart = new(26, "Franchise Donut Chart", "Displays a donut chart of the franchises of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems FranchisePieChart = new(17, "Franchise Pie Chart", "Displays a pie chart of the franchises of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems ItemTypeDonutChart = new(27, "Item Type Donut Chart", "Displays a donut chart of all the item types in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems ItemTypePieChart = new(1, "Item Type Pie Chart", "Displays a pie chart of all the item types in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems MemorabiliaAcquisitionTypeDonutChart = new(28, "Memorabilia Acquisition Type Donut Chart", "Displays a donut chart of the different acquisition types of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems MemorabiliaAcquisitionTypePieChart = new(4, "Memorabilia Acquisition Type Pie Chart", "Displays a pie chart of the different acquisition types of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems MemorabiliaConditionDonutChart = new(38, "Memorabilia Condition Donut Chart", "Displays a donut chart of the different conditions of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems MemorabiliaConditionPieChart = new(7, "Memorabilia Condition Pie Chart", "Displays a pie chart of the different conditions of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems MemorabiliaPurchaseTypeDonutChart = new(30, "Memorabilia Purchase Type Donut Chart", "Displays a donut chart of all the purchase types of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems MemorabiliaPurchaseTypePieChart = new(10, "Memorabilia Purchase Type Pie Chart", "Displays a pie chart of all the purchase types of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems SizeDonutChart = new(19, "Size Donut Chart", "Displays a donut chart of the sizes of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems SizePieChart = new(9, "Size Pie Chart", "Displays a pie chart of the sizes of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems SportLeagueLevelDonutChart = new(31, "Sport League Level Donut Chart", "Displays a donut chart of the sport league levels of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems SportLeagueLevelPieChart = new(16, "Sport League Level Pie Chart", "Displays a pie chart of the sport league levels of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems SportDonutChart = new(32, "Sport Donut Chart", "Displays a donut chart of the sports of the memorabilia in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems SportPieChart = new(18, "Sport Pie Chart", "Displays a pie chart of the sports of the memorabilia in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems SpotDonutChart = new(33, "Spot Donut Chart", "Displays a donut chart of the spots of the autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems SpotPieChart = new(13, "Spot Pie Chart", "Displays a pie chart of the spots of the autographs in your collection.", DashboardChartTypes.Pie);
    public static readonly DashboardItems WritingInstrumentDonutChart = new(34, "Autograph Writing Instrument Donut Chart", "Displays a donut chart of all the writing instruments of the autographs in your collection.", DashboardChartTypes.Donut);
    public static readonly DashboardItems WritingInstrumentPieChart = new(11, "Autograph Writing Instrument Pie Chart", "Displays a pie chart of all the writing instruments of the autographs in your collection.", DashboardChartTypes.Pie);

    public static readonly DashboardItems[] All =
    [
        AutographAcquisitionTypeDonutChart,
        AutographAcquisitionTypePieChart,
        AutographConditionDonutChart,            
        AutographConditionPieChart,            
        BrandDonutChart,
        BrandPieChart,
        ColorDonutChart,
        ColorPieChart,
        CostDonutChart,
        CostPieChart,
        EstimatedValueDonutChart,
        EstimatedValuePieChart,
        FranchiseDonutChart,
        FranchisePieChart,
        ItemTypeDonutChart,
        ItemTypePieChart,
        MemorabiliaAcquisitionTypeDonutChart,
        MemorabiliaAcquisitionTypePieChart,
        MemorabiliaConditionDonutChart,
        MemorabiliaConditionPieChart,
        MemorabiliaPurchaseTypeDonutChart,
        MemorabiliaPurchaseTypePieChart,
        SizeDonutChart,
        SizePieChart,
        SportLeagueLevelDonutChart,
        SportLeagueLevelPieChart,
        SportPieChart,
        SportDonutChart,
        SpotDonutChart,
        SpotPieChart,
        WritingInstrumentDonutChart,
        WritingInstrumentPieChart
    ];

    private DashboardItems(int id, string name, string description, DashboardChartTypes dashboardChartType)
        : base(id, name)
    {
        Description = description;
        DashboardChartType = dashboardChartType;
    }

    public DashboardChartTypes DashboardChartType { get; }

    public string Description { get; }

    public static DashboardItems Find(int id)
        => All.SingleOrDefault(DashboardItems => DashboardItems.Id == id);

    public override string ToString()
        => Name.Replace(" ", "");
}
